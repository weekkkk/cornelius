<script lang="ts" setup>
import { computed, ref, useSlots, onUnmounted, nextTick, watch } from 'vue';

/** Свойства */
const props = defineProps({
  /** Шаг */
  step: { type: Number, default: 1 },
  /** Шаг при прокрутке колесиком мыши */
  wheelStep: { type: Number, default: 0 },
  /** Циклична ли карусель */
  isLoop: { type: Boolean, default: false },
});
/** Обетка элементов */
const $elements_wrapper = ref<HTMLElement>();
/** Контейнер элементов */
const $elements_container = ref<HTMLElement>();
/** Элементы */
const $elements = ref<HTMLElement>();
/** Копия элементов */
const $elements_clone = ref<HTMLElement>();
const slots = useSlots();

/** Изменился ли размер окна */
const isUpdate = ref<boolean>();
const isResize = ref(false);
const onResize = async () => {
  await nextTick();
  if (!$elements.value || !$elements_wrapper.value) return;
  if ($elements.value.offsetWidth <= $elements_wrapper.value.offsetWidth)
    isUpdate.value = true;
  else isUpdate.value = false;
  isResize.value = true;
};
window.addEventListener('resize', onResize);

/** Дизейбл карусели */
const isDisabled = computed(() => {
  if (isUpdate.value) setUpd();
  return !(
    slots.default?.() &&
    slots.default()?.length &&
    elements.value?.length &&
    $elements_wrapper.value &&
    $elements.value &&
    $elements_wrapper.value.offsetWidth < $elements.value.offsetWidth
  );
});
const setUpd = () => {
  if (isUpdate.value != undefined) isUpdate.value = undefined;
};

/** Элементы карусели */
const elements = computed((): HTMLElement[] => {
  const elements: HTMLElement[] = [];
  if ($elements.value) {
    const children = $elements.value.children;
    for (let i = 0; i < children.length; i++)
      elements.push(children[i] as HTMLElement);
    if ($elements_clone.value && props.isLoop && !isDisabled.value) {
      const children = $elements_clone.value.children;
      for (let i = 0; i < children.length; i++)
        elements.push(children[i] as HTMLElement);
    }
  }
  return elements;
});
/** Кол-во пройденных элементов */
const offset = ref(0);
/** Макс кол-во пройденных элементов */
const maxOffset = computed(() => {
  let maxOffset = 0;
  if (isDisabled.value) return 0;
  if (maxX.value && elements.value?.length)
    maxOffset = elements.value.findIndex((el) => el?.offsetLeft >= maxX.value);
  if (maxOffset == -1) maxOffset = elements.value.length - 1;
  return maxOffset;
});
/** Анимация */
const isTransition = ref(false);
/** Текущее смещение по x */
const x = computed({
  get: (): number => {
    let resX = 0;

    if (maxX.value && elements.value?.length)
      resX = elements.value[Math.floor(offset.value)]?.offsetLeft;
    if (!props.isLoop && offset.value == elements.value.length - 1) {
      resX = maxX.value;
    }
    if (isDrag.value) {
      resX +=
        elements.value[Math.floor(offset.value + 1)]?.offsetLeft *
        (offset.value - Math.floor(offset.value));
      resX = Math.round(resX);
    }
    if (resX > maxX.value && !props.isLoop) resX = maxX.value;

    return resX;
  },
  set: (newX: number) => {
    if (!maxX.value) return;
    let newOffset: number = offset.value;
    if (!isDrag.value)
      newOffset = elements.value.findIndex((el) => el.offsetLeft >= newX);
    else {
      newOffset = elements.value.findIndex((el) => el.offsetLeft > newX);
      if (newOffset > 0)
        newOffset +=
          (newX - elements.value[newOffset - 1].offsetLeft) /
            elements.value[newOffset].offsetLeft -
          1;
    }
    if (newOffset < 0) return;
    if (newOffset > maxOffset.value) newOffset = maxOffset.value;
    offset.value = newOffset;
  },
});
/** Максимальное смещение по x */
const maxX = computed(() => {
  let maxX = 0;
  if (isDisabled.value) return 0;
  if ($elements_wrapper.value && $elements.value && $elements_container.value) {
    const wrap_w = $elements_wrapper.value.offsetWidth;
    const els_w = $elements_container.value.offsetWidth;
    if (wrap_w >= els_w) return maxX;
    maxX = els_w - wrap_w;
  }
  return maxX;
});

watch(isResize, () => {
  if (isResize.value) isResize.value = false;
});
/** Шаг назад */
const back = (step: number = props.step) => {
  isTransition.value = true;
  let newOffset = offset.value - step;
  const dif = newOffset - 0;
  if (dif < 0 && !props.isLoop) newOffset -= dif;
  if (props.isLoop && newOffset < 0) {
    newOffset += elements.value.length / 2;
  }
  if (props.isLoop && newOffset > offset.value) {
    isTransition.value = false;
    newOffset += step;
    setTimeout(() => {
      isTransition.value = true;
      offset.value -= step;
    });
  }
  if (newOffset == offset.value) return;
  offset.value = newOffset;
};
/** Шаг вперед */
const next = (step: number = props.step) => {
  isTransition.value = true;
  let newOffset = offset.value + step;
  const dif = newOffset - maxOffset.value;
  if (dif >= 0 && !props.isLoop) newOffset -= dif;
  if (props.isLoop && newOffset >= maxOffset.value) {
    newOffset -= elements.value.length / 2;
  }
  if (props.isLoop && newOffset < offset.value) {
    isTransition.value = false;
    newOffset -= step;
    setTimeout(() => {
      isTransition.value = true;
      offset.value += step;
    });
  }
  if (newOffset == offset.value) return;
  if (newOffset < 0) newOffset = 0;
  offset.value = newOffset;
};
/** Перетаскиванется ли элемент */
const isDrag = ref(false);
/** При перетаскивании мышью */
const mousedown = (e: MouseEvent) => {
  if (isDisabled.value || !e || isDrag.value) return;
  window.addEventListener('mousemove', mousemove);
  window.addEventListener('mouseup', mouseup);
  start(e.pageX);
};
const mousemove = (e: MouseEvent) => {
  if (!e || !isDrag.value) return;
  drag(e.pageX);
};
const mouseup = (e: MouseEvent) => {
  if (!e || !isDrag.value) return;
  stop(e.pageX);
  window.removeEventListener('mousemove', mousemove);
  window.removeEventListener('mouseup', mouseup);
};
/** При перетаскивании пальцем */
const touchstart = (e: TouchEvent) => {
  if (isDisabled.value || !e || isDrag.value) return;
  window.addEventListener('touchmove', touchmove);
  window.addEventListener('touchend', touchend);
  start(e.changedTouches[0].pageX);
};
const touchmove = (e: TouchEvent) => {
  if (!e || !isDrag.value) return;
  drag(e.changedTouches[0].pageX);
};
const touchend = (e: TouchEvent) => {
  if (!e || !isDrag.value) return;
  window.removeEventListener('touchmove', touchmove);
  window.removeEventListener('touchend', touchend);
  stop(e.changedTouches[0].pageX);
};
/** Налальный x при перетаскинии */
const startX = ref(0);
const startPageX = ref(0);
/** Начало перетаскивания */
const start = (pageX: number) => {
  isTransition.value = false;
  startPageX.value = pageX;
  startX.value = x.value;
  isDrag.value = true;
};
/** При перетаскинии */
const drag = (pageX: number) => {
  if (!isDrag.value) return;
  let newX = startX.value + (startPageX.value - pageX);
  if (props.isLoop && newX >= maxX.value) {
    newX -= elements.value[elements.value.length / 2].offsetLeft;
  }
  if (props.isLoop && newX <= 0) {
    newX += elements.value[elements.value.length / 2].offsetLeft;
  }
  x.value = newX;
};
/** Остановка перетаскивания */
const stop = (pageX: number) => {
  if (!isDrag.value) return;
  window.removeEventListener('mousemove', mousemove);
  window.removeEventListener('mouseup', mouseup);
  isDrag.value = false;
  isTransition.value = true;
  const endX = startX.value + (startPageX.value - pageX);
  offset.value = Math.floor(offset.value);
  if (
    endX - elements.value[Math.floor(offset.value)].offsetLeft >
    elements.value[Math.floor(offset.value)].offsetWidth / 2
  ) {
    offset.value++;
  }
};
/** Прокрутка колесиком мыши */
const wheel = (e: WheelEvent) => {
  if (!props.wheelStep) return;
  if ((e.deltaY || e.deltaX) > 0) {
    next(props.wheelStep);
  } else if ((e.deltaY || e.deltaX) < 0) {
    back(props.wheelStep);
  }
};

onUnmounted(() => {
  window.removeEventListener('mousemove', mousemove);
  window.removeEventListener('mouseup', mouseup);
  window.removeEventListener('touchmove', touchmove);
  window.removeEventListener('touchend', touchend);
  window.removeEventListener('resize', onResize);
});
</script>

<template>
  <div class="n-carousel">
    <!-- Обетка элементов карусели -->
    <div
      class="elements-wrapper"
      ref="$elements_wrapper"
      @mousedown.prevent="mousedown"
      @touchstart="touchstart"
      @wheel="wheel"
    >
      <!-- Элементы карусели -->
      <div
        class="elements-container"
        :class="{ 'is-transition': isTransition }"
        :style="{ transform: `translateX(-${x}px)` }"
        ref="$elements_container"
      >
        <div class="elements" ref="$elements">
          <slot />
        </div>
        <div
          v-if="isLoop && !isDisabled"
          class="elements"
          ref="$elements_clone"
        >
          <slot />
        </div>
      </div>
    </div>
    <!-- Кноки изменения кол-ва пройденых элементов -->
    <Transition name="action_visible">
      <div
        class="action back"
        @click="back()"
        v-if="!isDisabled && (offset > 0 || isLoop)"
      >
        <slot name="back" />
      </div>
    </Transition>
    <Transition name="action_visible">
      <div
        class="action next"
        @click="next()"
        v-if="!isDisabled && (offset < maxOffset || isLoop)"
      >
        <slot name="next" />
      </div>
    </Transition>
  </div>
</template>

<style lang="scss">
:root {
  --n-carousel-cg: 0;
  --n-carousel-ts: 0.5s;
  --n-carousel-action-tx: -16px;
}
</style>

<style lang="scss" scoped>
.n-carousel {
  // pos
  position: relative;
  // flex
  display: inline-flex;
  align-items: center;
  justify-content: center;
  gap: var(--n-carousel-cg);
  // size
  max-width: 100%;
  width: 100%;
  // Обертка элементов карусели
  .elements-wrapper {
    // flex
    display: inherit;
    align-items: inherit;
    gap: inherit;
    // size
    max-width: inherit;
    // visible
    overflow: hidden;
    // size
    width: fit-content;
    // Контейнер для элементов
    .elements-container {
      // flex
      display: inherit;
      align-items: inherit;
      gap: inherit;
      // size
      min-width: fit-content;
      // Элементы карусели
      .elements {
        // flex
        display: inherit;
        align-items: inherit;
        gap: inherit;
        // size
        min-width: inherit;
      }
      &.is-transition {
        // transition
        transition: var(--n-carousel-ts);
      }
    }
  }
  // Кнопка шага
  .action {
    // pos
    position: absolute;
    // Назад
    &.back {
      left: 0;
      transform: translateX(calc(var(--n-carousel-action-tx) * -1));
    }
    // Вперед
    &.next {
      right: 0;
      transform: translateX(var(--n-carousel-action-tx));
    }
  }
  .action_visible-enter-active,
  .action_visible-leave-active {
    transition: var(--n-carousel-ts);
    transition-property: opacity transform;
  }
  .action_visible-enter-from,
  .action_visible-leave-to {
    transform: scale(0);
    transform-origin: top;
    opacity: 0;
  }
}
</style>
