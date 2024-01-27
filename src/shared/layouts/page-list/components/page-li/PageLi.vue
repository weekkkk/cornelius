<script lang="ts" setup generic="T">
import { computed, onMounted, ref } from 'vue'
import type { PageType } from './types'
import { useRoute } from 'vue-router';

const props = defineProps<PageType<T>>()

const $el = ref<HTMLElement>()

const route = useRoute()

const isActive = computed(() => {
  return route.hash.slice(1).split('-').includes(props.hash)
})

const top = ref<number>()
const height = ref<number>()
const bottom = ref<number>()

const calcSize = () => {
  const rect = $el.value?.getBoundingClientRect()
  if (!rect) return
  top.value = rect.top
  height.value = rect.height
  bottom.value = rect.bottom
}

onMounted(() => {
  if (window.innerWidth <= 1024 && isActive.value) {
    calcSize()
    window.scrollTo(0, top.value || 0)
  }
})

defineExpose({ hash: props.hash, isActive, top, bottom, height, calcSize })
</script>

<template>
  <div ref="$el" class="page_li" :class="{ 'page_li-active': isActive }" :id="hash">
    <component :is="(component as any)" />
  </div>
</template>

<style lang="scss" scoped>
.page_li {
  display: grid;
  grid-template-columns: var(--corn-page-px) repeat(7, 1fr) var(--corn-page-px);
  grid-template-rows: var(--corn-page-py) repeat(7, 1fr) var(--corn-page-py);
  height: 100vh;
  position: relative;
  overflow: hidden;

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
