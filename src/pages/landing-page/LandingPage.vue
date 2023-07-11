<script lang="ts" setup>
import type { PageType } from '@/entities'

import * as pageComponents from './pages'

const pages: PageType<typeof pageComponents.MainPage>[] = [
  {
    hash: '#main',
    component: pageComponents.MainPage
  },
  {
    hash: '#equipment',
    component: pageComponents.EquipmentPage
  },
  {
    hash: '#design',
    component: pageComponents.DesignPage
  },
  {
    hash: '#news',
    component: pageComponents.NewsPage
  },
  {
    hash: '#contacts',
    component: pageComponents.ContactsPage
  }
]
</script>

<template>
  <div class="landing_page f fd-col">
    <div class="landing_page-page" v-for="page in pages" :key="page.hash" :id="page.hash">
      <component :is="page.component" />
    </div>
  </div>
</template>

<style lang="scss" scoped>
.landing_page {
  &-page {
    height: 100vh;
  }
}
</style>
