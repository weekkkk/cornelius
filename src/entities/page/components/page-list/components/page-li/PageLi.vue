<script lang="ts" setup generic="T">
import { computed, onMounted } from 'vue'
import type { PageType } from '../../../../types'
import { useRoute, useRouter } from 'vue-router'

const props = defineProps<{
  page: PageType<T>
}>()

const route = useRoute()
const router = useRouter()
const hash = `#${props.page.id}`

const isActive = computed(() => {
  return route.hash == hash
})

onMounted(() => {
  if (isActive.value) router.replace({ hash })
})
</script>

<template>
  <div class="page_li" :class="{ 'page_li-active': isActive }" :id="page.id">
    <div class="page_li-bg">
      <div class="page_li-bg-line" v-for="i in 9" :key="i" />
    </div>
    <div class="page_li-content">
      <component :is="page.component" />
    </div>
  </div>
</template>

<style lang="scss" scoped>
.page_li {
  overflow: hidden;
  height: 100vh;
  position: relative;
  &-active {
    transform: translateX(0);
    z-index: 1;
    top: 0;
    bottom: 0;
    background-color: var(--n-default);
    @media (min-width: 721px) {
      position: sticky;
    }
    .page_li-content {
      opacity: 1;
    }
  }
  --page-px: 116px;
  &-bg {
    &-line {
      &:not(:last-child) {
        border-right: 1px solid var(--n-second-0);
      }
      @media (max-width: 1440px) {
        &:nth-child(7) {
          border-right: none;
          ~ .page_li-bg-line {
            display: none;
          }
        }
      }
      @media (max-width: 800px) {
        &:nth-child(5) {
          border-right: none;
          ~ .page_li-bg-line {
            display: none;
          }
        }
      }
    }
  }
  &-bg,
  &-content {
    position: absolute;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;
    display: grid;
    grid-template-columns: var(--page-px) repeat(7, 1fr) var(--page-px);
    @media (max-width: 1600px) {
      --page-px: 64px;
    }
    @media (max-width: 1440px) {
      --page-px: 32px;
      grid-template-columns: var(--page-px) repeat(5, 1fr) var(--page-px);
    }
    @media (max-width: 800px) {
      --page-px: 16px;
      grid-template-columns: var(--page-px) repeat(3, 1fr) var(--page-px);
    }
  }
  &-content {
    opacity: 0;
    transition: 1s ease;
    transition-property: opacity;
    grid-template-rows: var(--page-px) repeat(5, 1fr) var(--page-px);
    @media (max-width: 800px) {
      --page-px: 16px;
      grid-template-rows: var(--page-px) minmax(64px, 1fr) fit-content(100px) 30% 1fr var(--page-px);
    }
  }
}
</style>
