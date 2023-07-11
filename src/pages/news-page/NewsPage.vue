<script lang="ts" setup>
import { TitleBlock } from '@/shared'
</script>

<template>
  <TitleBlock
    style="align-items: center"
    :x-start="2"
    x-end="end"
    :y-start="1"
    y-end="end"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="1"
    mobile-y-end="end"
  >
    <h2>Раздел находится в разработке</h2>
  </TitleBlock>
</template>

<style lang="scss" scoped>
.news_page {
  flex-grow: 1;
}
</style>
