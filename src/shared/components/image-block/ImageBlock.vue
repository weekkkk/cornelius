<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = withDefaults(defineProps<GridPositionType & { src: string; aspectRatio?: string }>(), {
  aspectRatio: '16 / 9'
})
</script>

<template>
  <figure
    class="image_block"
    :class="{ 'image_block-mobile_hide': isMobileHide, 'image_block-mobile_show': isMobileShow }"
  >
    <img :src="src" />
  </figure>
</template>

<style lang="scss" scoped>
.image_block {
  grid-column-start: v-bind(l);
  grid-column-end: v-bind(r);
  grid-row-start: v-bind(t);
  grid-row-end: v-bind(b);
  overflow: hidden;
  > img {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }
  @media (min-width: 961px) {
    &.image_block-mobile_show {
      display: none;
    }
  }
  @media (max-width: 960px) {
    &.image_block-mobile_hide {
      display: none;
    }
    aspect-ratio: v-bind(aspectRatio);
  }
}
</style>
