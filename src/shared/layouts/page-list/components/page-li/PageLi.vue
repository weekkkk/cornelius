<script lang="ts" setup generic="T">
import { onMounted, ref } from 'vue'
import type { PageType } from './types'

const props = defineProps<PageType<T>>()

const $el = ref<HTMLElement>()

// const rect = ref<DOMRect>()

// onMounted(() => {
//   if (!$el.value) return
//   rect.value = $el.value?.getBoundingClientRect()
//   console.log(rect.value.top, props.hash)
// })
</script>

<template>
  <div ref="$el" class="page_li" :id="hash">
    <component :is="component" />
  </div>
</template>

<style lang="scss" scoped>
.page_li {
  display: grid;
  grid-template-columns: var(--corn-page-px) repeat(7, 1fr) var(--corn-page-px);
  grid-template-rows: var(--corn-page-py) repeat(7, 1fr) var(--corn-page-py);
  height: 100vh;

  @media (max-width: 1024px) {
    aspect-ratio: 16 / 9;
    height: auto;
  }

  @media (max-width: 960px) {
    aspect-ratio: 0;
    min-height: 100vh;
    height: fit-content;
    grid-template-columns: var(--corn-page-px) repeat(3, 1fr) var(--corn-page-px);
  }
}
</style>
