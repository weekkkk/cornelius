<script lang="ts" setup>
import type { GridPositionType } from '../types'
import { ArrowIcon } from '@/app'

const props = defineProps<GridPositionType>()

const emit = defineEmits<{
  (e: 'click'): void
}>()
</script>

<template>
  <div class="button_block button_block-wrap f fd-col">
    <div class="button_block-el f fd-col">
      <button class="ff-OS" @click="emit('click')">
        <slot />
      </button>
    </div>

    <!-- <div class="button_block-arrow_1">
      <img :src="ArrowIcon" />
      <p class="c-second-50">
        Успех Корнелиус является результатом его технологичеких инноваций и опыта, накопленного на
        протяжении своей более чем 47-летней истории
      </p>
    </div> -->
  </div>
</template>

<style lang="scss" scoped>
.button_block {
  // &-arrow_1 {
  //   position: absolute;
  //   left: 100%;
  //   > img {
  //     transform: scale(-1, 1) rotate(30deg);
  //   }
  //   > p {
  //     width: 300px;
  //     transform: rotate(-7deg) translateX(-60px) translateY(-50px);
  //   }
  // }
  &-wrap {
    position: relative;
    grid-column-start: v-bind(xStart);
    grid-column-end: v-bind(xEnd);
    grid-row-start: v-bind(yStart);
    grid-row-end: v-bind(yEnd);
    @media (max-width: 800px) {
      grid-column-start: v-bind(mobileXStart);
      grid-column-end: v-bind(mobileXEnd);
      grid-row-start: v-bind(mobileYStart);
      grid-row-end: v-bind(mobileYEnd);
    }
  }
  &-el {
    overflow: hidden;
    > button {
      transition: 1s ease;
      min-width: fit-content;
      white-space: nowrap;
    }
  }
}
</style>

<style lang="scss">
.page_li:not(.page_li-active) {
  .button_block-el {
    > button {
      transform: translateY(-100%);
    }
  }
}
</style>
