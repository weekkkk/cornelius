<template>
  <router-view />
</template>

<style lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;0,800;1,300;1,400;1,500;1,600;1,700;1,800&display=swap');

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
