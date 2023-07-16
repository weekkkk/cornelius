<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType & { src: string }>()
</script>

<template>
  <figure class="image_block">
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
}
</style>
