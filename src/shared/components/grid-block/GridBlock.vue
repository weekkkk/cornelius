<script lang="ts" setup>
import type { GridPositionType } from '../types'

const props = defineProps<GridPositionType>()
</script>

<template>
  <div class="grid_block f fd-col">
    <slot />
  </div>
</template>

<style lang="scss" scoped>
.grid_block {
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
  // background-color: rgba(0, 0, 0, 0.5);
}
</style>
