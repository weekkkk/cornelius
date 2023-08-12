<script lang="ts" setup generic="T">
import { PageLi, type PageType } from './components'

const props = defineProps<{
  pages: PageType<T>[]
}>()
</script>

<template>
  <div class="page_list f fd-col">
    <PageLi v-for="page in pages" :hash="page.hash" :component="page.component" />
  </div>
</template>

<style lang="scss" scoped>
.page_list {
  position: relative;
}
</style>
