<script lang="ts" setup>
import { onMounted, type DefineComponent, onBeforeUnmount } from 'vue'
import { PageList, type PageType } from '@/entities'
import * as pageComponents from '@/pages'
const pages: PageType<typeof pageComponents.MainPage>[] = [
  {
    id: 'main',
    component: pageComponents.MainPage
  },
  {
    id: 'equipment',
    component: pageComponents.EquipmentPage
  },
  {
    id: 'desing',
    component: pageComponents.DesignPage
  },
  {
    id: 'news',
    component: pageComponents.NewsPage
  },
  {
    id: 'contacts',
    component: pageComponents.ContactsPage
  }
]
</script>

<template>
  <PageList :pages="pages" />
</template>

<style lang="scss" scoped></style>
