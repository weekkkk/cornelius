<script lang="ts" setup generic="T">
import { computed, onBeforeUnmount, onMounted, ref } from 'vue'
import type { PageType } from '../../../../types'
import { useRoute, useRouter } from 'vue-router'

const props = defineProps<{
  page: PageType<T>
  index: number
}>()

const route = useRoute()
const router = useRouter()
const hash = `#${props.page.id}`

const isActive = computed(() => {
  return route.hash == hash
})

const isReplace = ref(false)

onMounted(() => {
  setTimeout(() => {
    if (isActive.value) {
      router.replace({ hash })
    }
    isReplace.value = true
  }, 1000)
})

const $el = ref<HTMLElement>()

const isMobileActive = ref(false)

const handleScroll = () => {
  if (!$el.value || window.innerWidth > 800) return
  if (props.index == 2) console.log('$el.value.offsetTop', window.scrollY / window.innerHeight)

  if (props.index == Math.round(window.scrollY / window.innerHeight)) {
    isMobileActive.value = true
  }
}

onMounted(() => {
  window.addEventListener('scroll', handleScroll)
})

onBeforeUnmount(() => {
  window.removeEventListener('scroll', handleScroll)
})
</script>

<template>
  <div
    class="page_li"
    ref="$el"
    :class="{ 'page_li-active': (isActive || isMobileActive) && isReplace }"
    :aria-rowindex="index"
    :id="page.id"
  >
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
    @media (min-width: 800px) {
      position: sticky;
    }
    .page_li-content {
      opacity: 1;
    }
  }
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
    @media (max-width: 1440px) {
      grid-template-columns: var(--page-px) repeat(5, 1fr) var(--page-px);
    }
    @media (max-width: 800px) {
      grid-template-columns: var(--page-px) repeat(3, 1fr) var(--page-px);
    }
  }
  &-content {
    opacity: 0;
    transition: 1s ease;
    transition-property: opacity;
    grid-template-rows: var(--page-px) repeat(5, 1fr) var(--page-px);
    @media (max-width: 800px) {
      grid-template-rows: var(--page-px) 1fr fit-content(500px) 1fr fit-content(
          200px
        ) var(--page-px);
    }
  }
}
</style>
