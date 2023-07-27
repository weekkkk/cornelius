<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType>()
</script>

<template>
  <div class="text_block fw-medium">
    <div class="text_block-content bg-second-0 f fd-col rg-2">
      <slot />
    </div>
  </div>
</template>

<style lang="scss" scoped>
.text_block {
  grid-column-start: v-bind(xStart);
  grid-column-end: v-bind(xEnd);
  grid-row-start: v-bind(yStart);
  grid-row-end: v-bind(yEnd);
  overflow: hidden;
  &-content {
    padding: var(--text_block-padding);
    max-width: 100vw;
    transition: 1s ease;
    width: 100%;
    height: 100%;
    object-fit: cover;
    justify-content: var(--text_block-jc);
  }
  @media (max-width: 800px) {
    &-content {
      --text_block-padding: 16px;
    }
    grid-column-start: v-bind(mobileXStart);
    grid-column-end: v-bind(mobileXEnd);
    grid-row-start: v-bind(mobileYStart);
    grid-row-end: v-bind(mobileYEnd);
  }
}
</style>

<style lang="scss">
:root {
  --text_block-padding: 32px 64px;
  --text_block-jc: center;
}
.page_li:not(.page_li-active) {
  .text_block-content {
    transform: translateX(-100%);
    > * {
      opacity: 0;
      transition-delay: 0s;
    }
  }
}
.page_li {
  .text_block-content {
    > * {
      transition: 0.5s ease;
      transition-delay: 0.5s;
    }
  }
}
</style>
