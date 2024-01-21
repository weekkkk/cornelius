<script lang="ts" setup>
import * as pageComponents from '@/pages'
import { PageList, type PageType } from '@/shared'
import { CorneliusLogo } from '@/app/assets'
import { useRoute } from 'vue-router'

type PageComponentType = typeof pageComponents.SuppliesPage
const pages: PageType<PageComponentType>[] = [
  {
    component: pageComponents.SuppliesPage,
    hash: 'supplies',
    name: 'Поставки'
  },
  {
    component: pageComponents.DesignPage,
    hash: 'design',
    name: 'Проектирование'
  },
  {
    component: pageComponents.AccreditationsPage,
    hash: 'accreditations',
    name: 'Аккредитации'
  },
  {
    component: pageComponents.ContactsPage,
    hash: 'contacts',
    name: 'Контакты'
  }
]

const route = useRoute()
</script>

<template>
  <PageList :pages="pages" />
  <header class="landing_layout-header f ai-c jc-sb">
    <img class="landing_layout-header-logo" :src="CorneliusLogo" />
    <div class="f g-4">
      <RouterLink
        :to="{ hash: `#${page.hash}` }"
        :class="{
          'landing_layout-header-link-active': `#${page.hash}` == route.hash
        }"
        class="landing_layout-header-link fs-h4 fw-medium"
        v-for="page in pages"
        >{{ page.name }}</RouterLink
      >
    </div>
  </header>

  <nav class="landing_layout-nav f fd-col ai-fe rg-5">
    <RouterLink
      :to="{ hash: `#${page.hash}` }"
      :class="{
        'landing_layout-nav-link-active': `#${page.hash}` == route.hash
      }"
      class="landing_layout-nav-link fs-h4 fw-medium"
      v-for="page in pages"
    />
  </nav>
</template>

<style lang="scss" scoped>
.landing_layout {
  &-header {
    padding: 0 var(--corn-page-px);
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    height: var(--corn-page-py);
    &-logo {
      height: 2rem;
    }
    &-link {
      color: inherit;
      text-decoration: none;
      transition: 0.5s;
      &:hover,
      &-active {
        color: var(--n-brand);
      }
    }
  }
  &-nav {
    position: fixed;
    right: 0;
    top: 50%;
    transform: translateY(-50%);
    &-link {
      width: 3rem;
      height: 0.5rem;
      background-color: var(--n-second-25);
      transition: 1s;
      &:not(.landing_layout-nav-link-active):hover {
        width: 4.5rem;
        background-color: var(--n-second-50);
      }
      &-active {
        transition-delay: 1s;
        background-color: var(--n-brand);
        width: 6rem;
      }
    }
  }
}
</style>
