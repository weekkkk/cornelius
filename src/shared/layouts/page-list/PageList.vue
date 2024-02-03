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
    const index = props.pages.findIndex((page) => page.hash == route.hash.slice(1).split('-')[0])
    return index == -1 ? undefined : index
  },
  set: (deltaY: number | undefined) => {
    if (!deltaY || activeIndex.value == undefined) return
    if (deltaY > 0 && activeIndex.value + 1 >= props.pages.length) return
    if (deltaY < 0 && activeIndex.value - 1 < 0) return
    router
      .replace({ hash: '#' + props.pages[activeIndex.value + (deltaY > 0 ? 1 : -1)].hash })
      .then(() => {
        isAnim.value = true
        setTimeout(() => (isAnim.value = false), 2000)
      })
  }
})

if (activeIndex.value == undefined) router.replace({ hash: '#' + props.pages[0].hash })

const isAnim = ref(false)

const onWheel = (e: WheelEvent) => {
  if (isAnim.value || window.innerWidth <= 1024) return
  activeIndex.value = e.deltaY
}

const onScroll = () => {
  if (window.innerWidth > 1024 || !pageElements.value) return

  for (let pageEL of pageElements.value) pageEL.calcSize()

  const wh = window.innerHeight
  const activeIndexes = pageElements.value
    .filter((el) => wh - el.bottom + el.height / 2 >= 0 && el.top + el.height / 2 >= 0)
    .map((el) => {
      const index = pageElements.value?.indexOf(el)
      if (index == undefined) return -1
      return index
    })
    
  if (activeIndexes.length == 0 && activeIndex.value != undefined)
    activeIndexes.push(activeIndex.value)

  router.replace({ hash: '#' + activeIndexes.map((index) => props.pages[index].hash).join('-') })
}

const onResize = () => {
  if (window.innerWidth > 1024) return
  onScroll()
}

onMounted(() => {
  window.addEventListener('wheel', onWheel)
  window.addEventListener('scroll', onScroll)
  window.addEventListener('resize', onResize)

  if (window.innerWidth <= 1024) {
    console.log('onScroll')

    setTimeout(onScroll, 1000)
  }
})
onUnmounted(() => {
  window.removeEventListener('wheel', onWheel)
})
</script>

<template>
  <!-- <div class="test">{{ activeIndex }}</div> -->
  <div class="page_list f fd-col">
    <PageLi
      ref="pageElements"
      v-for="page in pages"
      :hash="page.hash"
      :component="page.component"
    />
  </div>
</template>

<style lang="scss" scoped>
.test {
  position: fixed;
  left: 0;
  top: 0;
  background-color: red;
  color: white;
  font-size: 90px;
}
.page_list {
  position: relative;
  top: calc(-100vh * v-bind(activeIndex));
  transition: 0s ease-in-out;
  @media (min-width: 1025px) {
    transition-delay: var(--corn-ts);
  }
  @media (max-width: 1024px) {
    top: 0;
  }
}
</style>
