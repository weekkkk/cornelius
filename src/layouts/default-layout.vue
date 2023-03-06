<script lang="ts" setup>
import { routes } from '@/router';
import { ref } from 'vue';
/**
 * * Номер
 */
const phone = '+373 777 83485';
/**
 * * Почта
 */
const email = 'corneliusgas@gmail.com';
/**
 * * Ссылки
 */
const links = (routes[0]?.children || []).map((route) => {
  return { name: route.name, title: route.meta?.Title + '' };
});
/**
 * * Видимость мобильного меню
 */
const mobileMenuVisible = ref(false);
</script>

<template>
  <header class="f jc-c px-4 bg-default">
    <div class="container f jc-sb ai-c cg-3">
      <img src="@/assets/images/logo.png" alt="Logo" height="54" />

      <div class="contacts f cg-4 ai-c">
        <div class="f fw-wrap jc-fe cg-3 rg-1">
          <a
            class="f ai-c cg-2 fs-small-p c-brand fw-medium"
            :href="`tel:${phone}`"
          >
            <span class="material-icons-round fs-p c-base"> phone </span>
            {{ phone }}
          </a>
          <a
            class="f ai-c cg-2 fs-small-p c-brand fw-medium"
            :href="`mailto:${email}`"
          >
            <span class="material-icons-round fs-p c-base"> mail </span>
            {{ email }}
          </a>
        </div>

        <div class="f g-3">
          <a class="lh-no" href="https://tlgg.ru/cornelius_gas">
            <img src="@/assets/images/icons/soc1.png" height="32" />
          </a>
          <a class="lh-no" href="viber://chat?number=%2B37377783485/">
            <img src="@/assets/images/icons/soc2.png" height="32" />
          </a>
          <a class="lh-no" href="https://wa.me/37377783485">
            <img src="@/assets/images/icons/soc3.png" height="32" />
          </a>
        </div>
      </div>

      <img
        class="mobile-menu-burder"
        src="@/assets/images/icons/burder.png"
        height="32"
        @click="mobileMenuVisible = true"
      />
    </div>
  </header>

  <nav class="f jc-c bg-brand p-4">
    <div class="container f jc-fe">
      <ul class="fs-small-p f ai-c cg-4 rg-3">
        <li v-for="link in links" :key="link.name">
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

  <main class="f fd-col w-100 rg-4">
    <RouterView />
  </main>

  <footer class="bg-second-100 c-default f jc-c p-4">
    <div class="container f cg-4 rg-4">
      <img src="@/assets/images/logo.png" alt="Logo" height="54" />

      <div class="info-column f fd-col rg-3 w-100 lh-loose">
        <h2 class="title pb-3 lh-no">Меню:</h2>

        <ul class="fs-small-p f fd-col rg-3">
          <li v-for="link in links" :key="link.name">
            <RouterLink :to="{ name: link.name }" class="c-default fw-medium">
              {{ link.title }}
            </RouterLink>
          </li>
        </ul>
      </div>

      <div class="info-column f fd-col rg-3 w-100 lh-loose">
        <h2 class="title pb-3 lh-no">Контакты:</h2>

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

  <footer class="info-row f ai-c jc-c bg-brand px-4 py-3">
    <div class="container f ai-c">
      <p class="c-second-0">© 2023 CORNELIUS. Все права защищены.</p>
    </div>
  </footer>

  <Transition name="mobile-menu">
    <div
      class="mobile-menu f jc-fe"
      @click="mobileMenuVisible = false"
      v-if="mobileMenuVisible"
    >
      <aside @click.stop class="f fd-col bg-second-100 py-4">
        <img
          @click="mobileMenuVisible = false"
          src="@/assets/images/icons/close.png"
          height="24"
        />
        <ul class="fs-small-p f fd-col">
          <li v-for="link in links" :key="link.name" class="f fd-col">
            <RouterLink
              :to="{ name: link.name }"
              class="px-4 f fd-col c-default fw-medium"
            >
              <span class="py-3">
                {{ link.title }}
              </span>
            </RouterLink>
          </li>
        </ul>
      </aside>
    </div>
  </Transition>
</template>

<style lang="scss" scoped>
header {
  height: 88px;
  box-shadow: 0 0 16px rgba($color: #000, $alpha: 0.2);
  z-index: 1;
  a:hover {
    color: var(--n-base);
  }
  .mobile-menu-burder {
    display: none;
  }
  @media (max-width: 624px) {
    .contacts {
      display: none;
    }
    .mobile-menu-burder {
      display: flex;
    }
  }
}
nav {
  height: 52px;
  a.large-link {
    text-transform: uppercase;
    &:hover {
      color: var(--n-base);
    }
  }
  @media (max-width: 972px) {
    flex-direction: column;
    height: auto;
    div.container {
      flex-direction: column;
      ul {
        flex-direction: column;
        align-items: flex-start;
      }
    }
  }
  @media (max-width: 624px) {
    display: none !important;
  }
}

main {
  flex-grow: 1;
}

footer {
  .info-column .title:not(:last-child) {
    border-bottom: 1px solid var(--n-default);
  }
  &.info-row {
    height: 64px;
  }

  a:hover {
    color: var(--n-brand);
  }

  @media (max-width: 972px) {
    div.container {
      flex-direction: column;
      align-items: flex-start;
    }
  }
}

.mobile-menu {
  position: fixed;
  right: 0;
  left: 0;
  top: 0;
  bottom: 0;
  z-index: 2;
  background-color: rgba($color: #000000, $alpha: 0.2);
  display: none;
  @media (max-width: 624px) {
    display: flex;
  }
  aside {
    width: 320px;

    img {
      position: absolute;
      top: 16px;
      right: 16px;
      filter: invert(100%);
    }

    ul li {
      a {
        &:hover {
          color: var(--n-brand);
        }
        span {
          border-bottom: 1px solid rgba($color: #000, $alpha: 0.2);
        }
      }
      &:hover {
        background-color: rgba($color: #000, $alpha: 0.2);
      }
    }
  }
  &-enter-active,
  &-leave-active {
    transition: opacity 0.5s ease;
  }
  &-enter-from,
  &-leave-to {
    opacity: 0;
  }
}
</style>
