<script lang="ts" setup>
import { MainPageVideo } from '@/app'
</script>

<template>
  <!-- <Teleport to="#app-video">
    <video preload="auto" no-controls autoplay loop playsinline muted>
      <source :src="MainPageVideo" type="video/mp4" />
    </video>
  </Teleport> -->
  <h1>Главная</h1>
  <RouterLink :to="{hash: '#equipment'}">test</RouterLink>
  <RouterLink :to="{hash: '#main'}">test</RouterLink>
</template>

<style lang="scss" scoped></style>
