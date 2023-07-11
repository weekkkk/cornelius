<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType>()
</script>

<template>
  <div class="text_block bg-second-0 fw-medium f fd-col jc-c rg-2">
    <slot />
  </div>
</template>

<style lang="scss" scoped>
.text_block {
  grid-column-start: v-bind(xStart);
  grid-column-end: v-bind(xEnd);
  grid-row-start: v-bind(yStart);
  grid-row-end: v-bind(yEnd);
  padding: 32px 64px;
  max-width: 100vw;
  transition: 1s ease;
  @media (max-width: 800px) {
    padding: 16px;
    grid-column-start: v-bind(mobileXStart);
    grid-column-end: v-bind(mobileXEnd);
    grid-row-start: v-bind(mobileYStart);
    grid-row-end: v-bind(mobileYEnd);
  }
}
</style>

<style lang="scss">
.page_li:not(.page_li-active) {
  .text_block {
    max-width: 0;
    padding-left: 0;
    padding-right: 0;
    > * {
      opacity: 0;
      transition-delay: 0s;
    }
  }
}
.page_li {
  .text_block {
    > * {
      overflow: hidden;
      transition: 0.5s ease;
      transition-delay: 0.5s;
    }
  }
}
</style>
