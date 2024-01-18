<script lang="ts" setup></script>

<template>
  <div class="app_bg">
    <div class="app_bg-line" v-for="i in 9" :key="i" />
  </div>
  <RouterView />
</template>

<style lang="scss">
#app {
  overflow: hidden;
  height: 100vh;
  @media (max-width: 1024px) {
    overflow: auto;
    height: auto;
  }
}
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
    &-line:nth-child(5) ~ .app_bg-line {
      display: none;
    }
  }
}

.grid_block {
  > *:not(.image_block) {
    transition: 1s ease-in-out;
    transform: translateX(-100%);
    opacity: 0;
    animation: 1s grid_block-load ease-in-out;
  }
  @keyframes grid_block-load {
    0% {
      opacity: 0;
      transform: translateX(-100%);
    }
    100% {
      opacity: 1;
      transform: translateX(0%);
    }
  }
}
.image_block {
  > * {
    transition: 1s ease-in-out;
    transform: translateY(100%);
    opacity: 0;
    animation: 1s image_block-load ease-in-out;
  }
  @keyframes image_block-load {
    0% {
      opacity: 0;
      transform: translateY(100%);
    }
    100% {
      opacity: 1;
      transform: translateY(0%);
    }
  }
}
.page_li-active {
  .grid_block {
    > *:not(.image_block) {
      transform: translateX(0%);
      opacity: 1;
      @media (min-width: 1025px) {
        transition-delay: 1s;
      }
    }
  }
  .image_block {
    > * {
      transform: translateY(0%);
      opacity: 1;
      @media (min-width: 1025px) {
        transition-delay: 1s;
      }
    }
  }
}
</style>
