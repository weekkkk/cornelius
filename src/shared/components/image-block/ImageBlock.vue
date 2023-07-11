<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType & { src: string }>()
</script>

<template>
  <figure class="image_block" :class="{ 'image_block-tablet-hide': isTabletHide }">
    <img :src="src" />
  </figure>
</template>

<style lang="scss" scoped>
.image_block {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  position: relative;
  grid-column-start: v-bind(xStart);
  grid-column-end: v-bind(xEnd);
  grid-row-start: v-bind(yStart);
  grid-row-end: v-bind(yEnd);
  overflow: hidden;
  > img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    transition: 1s ease;
  }
  @media (max-width: 1440px) {
    &-tablet-hide {
      display: none;
    }
  }
  @media (max-width: 800px) {
    grid-column-start: v-bind(mobileXStart);
    grid-column-end: v-bind(mobileXEnd);
    grid-row-start: v-bind(mobileYStart);
    grid-row-end: v-bind(mobileYEnd);
  }
}
</style>

<style lang="scss">
.page_li:not(.page_li-active) {
  .image_block {
    > img {
      transform: translateY(100%);
    }
  }
}
</style>
