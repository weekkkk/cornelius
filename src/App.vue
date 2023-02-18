<template>
  <router-view />
</template>

<style lang="scss">
* {
  box-sizing: border-box;
  padding: 0;
  margin: 0;
}
html {
  // font-family: 'Montserrat';
  font-size: var(--n-fs-p);
  color: var(--n-base);
}

body {
  font-family: 'Open Sans', sans-serif;
  line-height: var(--n-lh-regular);
  display: flex;
  min-height: 100vh;
}

#app {
  width: 100%;
  display: flex;
  flex-direction: column;
}

a {
  text-decoration: none;
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
