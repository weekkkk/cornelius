<script lang="ts" setup>
const props = defineProps<{
  visible: boolean
}>()

const emit = defineEmits<{ (e: 'hide'): void }>()
</script>

<template>
  <Transition name="modal_window-ts">
    <div v-show="visible" class="modal_window-bg f ai-c jc-c" @click="emit('hide')">
      <div class="modal_window" @click.stop>
        <slot />
      </div>
    </div>
  </Transition>
</template>

<style lang="scss" scoped>
.modal_window {
  background-color: var(--n-default);
  width: 40%;
  padding: 1.5rem;
  &-bg {
    background-color: rgba(0, 0, 0, 0.5);
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
  }
}
.modal_window-ts-enter-active,
.modal_window-ts-leave-active {
  transition: opacity 0.5s ease;
}

.modal_window-ts-enter-from,
.modal_window-ts-leave-to {
  opacity: 0;
}
</style>
