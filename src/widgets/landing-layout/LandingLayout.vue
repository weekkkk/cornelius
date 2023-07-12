<script lang="ts" setup>
import { onMounted, type DefineComponent, onBeforeUnmount } from 'vue'
import { PageList, PagesNavbar, type PageType } from '@/entities'
import * as pageComponents from '@/pages'
import { CorneliusLogo } from '@/app'
const pages: PageType<typeof pageComponents.MainPage>[] = [
  {
    id: 'main',
    title: 'Главная',
    component: pageComponents.MainPage
  },
  {
    id: 'equipment',
    title: 'Оборудование',
    component: pageComponents.EquipmentPage
  },
  {
    id: 'desing',
    title: 'Проектирование',
    component: pageComponents.DesignPage
  },
  {
    id: 'news',
    title: 'Новости',
    component: pageComponents.NewsPage
  },
  {
    id: 'contacts',
    title: 'Контакты',
    component: pageComponents.ContactsPage
  }
]
</script>

<template>
  <div class="landing_layout-header-wrap">
    <header class="landing_layout-header f jc-sb">
      <img width="164" :src="CorneliusLogo" alt="Logo" />

      <PagesNavbar :pages="pages" />
    </header>
  </div>

  <PageList :pages="pages" />
</template>

<style lang="scss" scoped>
.landing_layout {
  &-header {
    grid-column-start: 2;
    grid-column-end: 3;
    &-wrap {
      position: fixed;
      z-index: 100;
      left: 0;
      right: 0;
      display: grid;
      grid-template-columns: var(--page-px) 1fr var(--page-px);
      padding: 32px 0;
    }
  }
}
</style>
