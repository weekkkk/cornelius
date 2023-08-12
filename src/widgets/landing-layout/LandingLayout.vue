<script lang="ts" setup>
import * as pageComponents from '@/pages'
import { PageList, type PageType } from '@/shared'

type PageComponentType = typeof pageComponents.SuppliesPage
const pages: PageType<PageComponentType>[] = [
  {
    component: pageComponents.SuppliesPage,
    hash: 'supplies'
  },
  {
    component: pageComponents.DesignPage,
    hash: 'design'
  },
  {
    component: pageComponents.AccreditationsPage,
    hash: 'accreditations'
  }
]
</script>

<template>
  <PageList :pages="pages" />
</template>

<style lang="scss" scoped></style>
