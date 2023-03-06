<template>
  <router-view />
</template>

<style lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;0,800;1,300;1,400;1,500;1,600;1,700;1,800&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Comfortaa:wght@300;400;500;600;700&family=Nunito:ital,wght@0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;0,1000;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900;1,1000&family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap');

.brand_slider {
  --n-carousel-cg: 16px;
  --n-carousel-action-tx: calc(100% + 8px);

  img {
    width: 98px;
  }

  &-wrap {
    padding: 0 var(--n-ctrl-large-sz);
  }
}

.material-icons-round {
  font-family: 'Material Icons';
  font-weight: normal;
  font-style: normal;
  font-size: 24px; /* Preferred icon size */
  display: inline-block;
  line-height: 1;
  text-transform: none;
  letter-spacing: normal;
  word-wrap: normal;
  white-space: nowrap;
  direction: ltr;

  /* Support for all WebKit browsers. */
  -webkit-font-smoothing: antialiased;
  /* Support for Safari and Chrome. */
  text-rendering: optimizeLegibility;

  /* Support for Firefox. */
  -moz-osx-font-smoothing: grayscale;

  /* Support for IE. */
  font-feature-settings: 'liga';
}

* {
  box-sizing: border-box;
  padding: 0;
  margin: 0;
}
html {
  font-size: var(--n-fs-p);
  color: var(--n-base);
}

body {
  font-family: 'Nunito', sans-serif;
  line-height: var(--n-lh-regular);
  display: flex;
  min-height: 100vh;
}

#app {
  width: 100%;
  display: flex;
  flex-direction: column;
}

.container {
  max-width: 1180px;
  width: 100%;
}

a {
  text-decoration: none;
  transition: 0.15s;
}

ul,
li {
  list-style: none;
  text-decoration: none;
}

table {
  $border: 1px solid var(--n-second-25);
  border-collapse: collapse;
  tr {
    td,
    th {
      vertical-align: top;
      padding: var(--n-indent-3);
      &:not(:last-child) {
        border-right: $border;
      }
    }
    &:not(:last-child) {
      td,
      th {
        border-bottom: $border;
      }
    }
  }
}
section.info {
  overflow: auto;
}
</style>
