<script lang="ts" setup></script>

<template>
  <RouterView />
</template>

<style lang="scss">
html {
  font-size: 20px;
  @media (max-width: 1900px) {
    font-size: 16px;
  }
}
::-webkit-scrollbar {
  display: none;
}
::selection {
  color: var(--n-default);
  background-color: var(--n-brand);
}
</style>
