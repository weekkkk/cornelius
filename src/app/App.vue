<script lang="ts" setup></script>

<template>
  <div class="app_bg">
    <div class="app_bg-line" v-for="i in 9" :key="i" />
  </div>
  <RouterView />
</template>

<style lang="scss">
html {
  font-size: 0.9375vw;
}
::-webkit-scrollbar {
  display: none;
}
::selection {
  color: var(--n-default);
  background-color: var(--n-brand);
}
.app_bg {
  display: grid;
  grid-template-columns: inherit;
  grid-column-start: 1;
  grid-column-end: end;
  grid-row-start: 1;
  grid-row-end: end;
  &-line {
    grid-row-start: 1;
    grid-row-end: end;
    &:not(:last-child) {
      border-right: 1px solid var(--n-second-0);
    }
  }
}
</style>
