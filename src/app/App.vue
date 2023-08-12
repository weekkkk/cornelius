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
  @media (max-width: 960px) {
    font-size: 14px;
  }
}
::-webkit-scrollbar {
  display: none;
}
::selection {
  color: var(--n-default);
  background-color: var(--n-brand);
}
.app_bg {
  position: fixed;
  left: 0;
  right: 0;
  top: 0;
  bottom: 0;
  display: grid;
  grid-template-columns: var(--corn-page-px) repeat(7, 1fr) var(--corn-page-px);
  grid-template-rows: var(--corn-page-py) repeat(7, 1fr) var(--corn-page-py);
  &-line {
    grid-row-start: 1;
    grid-row-end: end;
    &:not(:last-child) {
      border-right: 1px solid var(--n-second-0);
    }
  }

  @media (max-width: 960px) {
    grid-template-columns: var(--corn-page-px) repeat(3, 1fr) var(--corn-page-px);
  }
}
</style>
