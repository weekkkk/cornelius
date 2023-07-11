<script lang="ts" setup>
import { computed } from 'vue'
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType>()

const emit = defineEmits<{
  (e: 'click'): void
}>()
</script>

<template>
  <div class="button_block f fd-col">
    <button class="ff-OS" @click="emit('click')">
      <slot />
    </button>
  </div>
</template>

<style lang="scss" scoped>
.button_block {
  grid-column-start: v-bind(xStart);
  grid-column-end: v-bind(xEnd);
  grid-row-start: v-bind(yStart);
  grid-row-end: v-bind(yEnd);
  > button {
    min-width: fit-content;
    white-space: nowrap;
  }
  @media (max-width: 800px) {
    grid-column-start: v-bind(mobileXStart);
    grid-column-end: v-bind(mobileXEnd);
    grid-row-start: v-bind(mobileYStart);
    grid-row-end: v-bind(mobileYEnd);
  }
}
</style>
