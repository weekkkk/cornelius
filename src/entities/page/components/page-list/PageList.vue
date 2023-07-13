<script lang="ts" setup generic="T">
import { computed, onBeforeUnmount, onMounted, provide, ref } from 'vue'
import type { PageType } from '../../types'
import { PageLi } from './components'
import { useRoute, useRouter } from 'vue-router'
const props = defineProps<{
  pages: PageType<T>[]
}>()

const route = useRoute()
const router = useRouter()

const page = computed(() => {
  return props.pages.find((page) => `#${page.id}` == route.hash)
})

const isNoScroll = ref(false)

const handleScroll = () => {
  if (isAnim.value) return
  const scrollPosition = window.scrollY
  const pageDecimalIndex = Number((scrollPosition / window.innerHeight).toFixed(1))
  if (!page.value) return
  let pageIndex = 0

  const currentPageIndex = props.pages.indexOf(page.value)
  if (window.innerWidth <= 800) {
    pageIndex =
      pageDecimalIndex < currentPageIndex
        ? Math.ceil(pageDecimalIndex)
        : Math.floor(pageDecimalIndex)
  } else {
    // pageIndex = Math.round(pageDecimalIndex)
    pageIndex =
      pageDecimalIndex < currentPageIndex
        ? Math.floor(pageDecimalIndex)
        : Math.ceil(pageDecimalIndex)
  }
  console.log({ pageDecimalIndex })
  const nextPage = props.pages[pageIndex]
  if (!page) return
  const newHash = `#${nextPage.id}`
  if (route.hash == newHash) return
  isNoScroll.value = false
  if (window.innerWidth < 800) isNoScroll.value = true
  router.replace({ hash: newHash })
}

onMounted(() => {
  window.addEventListener('scroll', handleScroll)
})

onBeforeUnmount(() => {
  window.removeEventListener('scroll', handleScroll)
})

const isAnim = ref(false)
</script>

<template>
  <div class="page_list f fd-col">
    <PageLi
      @start-anim="isAnim = true"
      @stop-anim="isAnim = false"
      v-for="(page, index) in pages"
      :key="page.id"
      :page="page"
      :index="index"
    />
  </div>
</template>

<style lang="scss" scoped></style>
