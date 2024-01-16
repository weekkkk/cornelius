<script lang="ts" setup generic="T">
import { computed, onMounted, onUnmounted, ref } from 'vue'
import { PageLi, type PageType } from './components'
import { useRoute, useRouter } from 'vue-router'

const props = defineProps<{
  pages: PageType<T>[]
}>()

const pageElements = ref<any[]>()

const route = useRoute()

const router = useRouter()

const activeIndex = computed({
  get: (): number | undefined => {
    const index = props.pages.findIndex((page) => '#' + page.hash == route.hash)
    return index == -1 ? undefined : index
  },
  set: (deltaY: number | undefined) => {
    if (!deltaY || activeIndex.value == undefined) return
    if (deltaY > 0 && activeIndex.value + 1 >= props.pages.length) return
    if (deltaY < 0 && activeIndex.value - 1 < 0) return
    router.replace({ hash: '#' + props.pages[activeIndex.value + (deltaY > 0 ? 1 : -1)].hash })
  }
})

if (activeIndex.value == undefined) router.replace({ hash: '#' + props.pages[0].hash })

const isAnim = ref(false)

const onWheel = (e: WheelEvent) => {
  if (isAnim.value || window.innerWidth <= 1024) return
  activeIndex.value = e.deltaY
  isAnim.value = true
  setTimeout(() => (isAnim.value = false), 2000)
}

const onScroll = () => {
  if (window.innerWidth > 1024 || !pageElements.value) return
  for (let pageEL of pageElements.value) pageEL.calcTop()
  let localActiveIndex = pageElements.value.findIndex((el) => el.top > 0) - 1

  if (localActiveIndex >= pageElements.value.length) return

  if (localActiveIndex < 0) localActiveIndex = pageElements.value.length - 1

  router.replace({ hash: '#' + props.pages[localActiveIndex].hash })
}

onMounted(() => {
  window.addEventListener('wheel', onWheel)
  window.addEventListener('scroll', onScroll)
})
onUnmounted(() => {
  window.removeEventListener('wheel', onWheel)
})
</script>

<template>
  <div class="page_list f fd-col">
    <PageLi
      ref="pageElements"
      v-for="page in pages"
      :hash="page.hash"
      :component="page.component"
      :active-hash="pages[activeIndex || 0].hash"
    />
  </div>
</template>

<style lang="scss" scoped>
.page_list {
  position: relative;
  top: calc(-100vh * v-bind(activeIndex));
  transition: 0s ease-in-out;
  @media (min-width: 1025px) {
    transition-delay: 1s;
  }
  @media (max-width: 1024px) {
    top: 0;
  }
}
</style>
