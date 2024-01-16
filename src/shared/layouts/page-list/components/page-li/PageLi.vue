<script lang="ts" setup generic="T">
import { computed, onMounted, ref } from 'vue'
import type { PageType } from './types'

const props = defineProps<PageType<T> & { activeHash: string }>()

const $el = ref<HTMLElement>()

const isActive = computed(() => props.activeHash && props.activeHash == props.hash)

const top = ref<number>()

const calcTop = () => {
  top.value = $el.value?.getBoundingClientRect().top
}

onMounted(() => {
  if (window.innerWidth <= 1024 && isActive.value) {
    console.log('test');
    
    calcTop()
    console.log(top.value)
    window.scrollTo(0, top.value || 0)
  }
})

defineExpose({ hash: props.hash, isActive, top, calcTop })
</script>

<template>
  <div
    ref="$el"
    class="page_li"
    :class="{ 'page_li-active': isActive }"
    :id="hash"
  >
    <component :is="(component as any)" />
  </div>
</template>

<style lang="scss" scoped>
.page_li {
  display: grid;
  grid-template-columns: var(--corn-page-px) repeat(7, 1fr) var(--corn-page-px);
  grid-template-rows: var(--corn-page-py) repeat(7, 1fr) var(--corn-page-py);
  height: 100vh;

  // &-active {
  //   animation: to_active 2s ease-in-out;
  //   animation-fill-mode: forwards;
  // }

  @media (max-width: 1024px) {
    aspect-ratio: 16 / 9;
    height: auto;
  }

  @media (max-width: 960px) {
    aspect-ratio: 0;
    min-height: 100vh;
    height: fit-content;
    grid-template-columns: var(--corn-page-px) repeat(3, 1fr) var(--corn-page-px);
  }
}
</style>
