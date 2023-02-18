<script lang="ts" setup>
import {
  MAIN,
  EQUIPMENT,
  DESIGN,
  NEWS,
  ORDER,
  CONTACTS,
} from '@/router/modules/names';

import { routes } from '@/router';
/**
 * * Номер
 */
const phone = '+373 777 83485';
/**
 * * Почта
 */
const email = 'corneliusgas@gmail.com';

const links = (routes[0]?.children || []).map((route) => {
  return { name: route.name, title: route.meta?.Title + '' };
});
</script>

<template>
  <header class="f jc-c px-4">
    <div class="container f jc-sb ai-c cg-3">
      <img src="@/assets/images/logo.png" alt="Logo" height="54" />

      <div class="contacts f cg-3">
        <a class="fs-small-p c-brand fw-medium" :href="`tel:${phone}`">{{
          phone
        }}</a>
        <a class="fs-small-p c-brand fw-medium" :href="`mailto:${email}`">{{
          email
        }}</a>
      </div>
    </div>
  </header>

  <nav class="f jc-c bg-brand px-4">
    <div class="container f jc-fe">
      <ul class="fs-small-p f ai-c cg-4">
        <li v-for="link in links">
          <RouterLink
            :to="{ name: link.name }"
            class="large-link c-default fw-medium"
          >
            {{ link.title }}
          </RouterLink>
        </li>
      </ul>
    </div>
  </nav>

  <main class="f fd-col w-100 p-4">
    <RouterView />
  </main>

  <footer class="bg-second-100 c-default f jc-c p-4">
    <div class="container f cg-4">
      <img src="@/assets/images/logo.png" alt="Logo" height="54" />

      <div class="info-column f fd-col rg-4 w-100 lh-loose">
        <h2 class="title pb-4">Меню:</h2>

        <ul class="fs-small-p f fd-col rg-3">
          <li v-for="link in links">
            <RouterLink :to="{ name: link.name }" class="c-default fw-medium">
              {{ link.title }}
            </RouterLink>
          </li>
        </ul>
      </div>

      <div class="info-column f fd-col rg-4 w-100 lh-loose">
        <h2 class="title pb-4">Контакты:</h2>

        <p class="title pb-4 fs-small-p fw-medium">
          Центральный офис: <br />
          Молдова, г.Тирасполь, ул. Карла-Либкнехта 385, каб. 201, 202, 204
          <br />
          E-mail: corneliusgas@gmail.com <br />
          Телефон:
          <a class="fs-small-p fw-medium c-default" :href="`tel:${phone}`">{{
            phone
          }}</a>
        </p>

        <p class="title pb-4 fs-small-p fw-medium">
          Производственно-техническая база:<br />
          с. Суклея, ул. Котовского 81. <br />
          Телефон:
          <a
            class="fs-small-p fw-medium c-default"
            :href="`tel:+373 533 24599`"
          >
            +373 533 24599
          </a>
        </p>
      </div>
    </div>
  </footer>
</template>

<style lang="scss" scoped>
header {
  height: 88px;
}
nav {
  height: 52px;
  a.large-link {
    text-transform: uppercase;
  }
}

.container {
  max-width: 1180px;
  width: 100%;
}

main {
  flex-grow: 1;
}

footer {
  .info-column .title {
    border-bottom: 1px solid var(--n-default);
  }
}
</style>
