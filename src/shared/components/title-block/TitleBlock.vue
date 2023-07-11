<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType>()
</script>

<template>
  <div class="title_block f ai-fe">
    <h1 class="ff-OS">
      <slot />
    </h1>
  </div>
</template>

<style lang="scss" scoped>
.title_block {
  grid-column-start: v-bind(xStart);
  grid-column-end: v-bind(xEnd);
  grid-row-start: v-bind(yStart);
  grid-row-end: v-bind(yEnd);
  overflow: hidden;
  transform: translateY(32px);
  > h1 {
    transition: transform 1s ease;
  }
  @media (max-width: 800px) {
  transform: translateY(16px);
    grid-column-start: v-bind(mobileXStart);
    grid-column-end: v-bind(mobileXEnd);
    grid-row-start: v-bind(mobileYStart);
    grid-row-end: v-bind(mobileYEnd);
  }
}
</style>

<style lang="scss">
.page_li:not(.page_li-active) {
  .title_block {
    > h1 {
      transform: translateX(-100%);
    }
  }
}
</style>
