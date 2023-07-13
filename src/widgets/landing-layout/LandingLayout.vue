<script lang="ts" setup>
import { onMounted, type DefineComponent, onBeforeUnmount, ref, provide } from 'vue'
import { PageList, PagesNavbar, type PageType } from '@/entities'
import * as pageComponents from '@/pages'
import { CorneliusLogo } from '@/app'
import { ContactForm } from '../contact-form'
const pages: PageType<typeof pageComponents.MainPage>[] = [
  {
    id: 'main',
    title: 'Главная',
    component: pageComponents.MainPage
  },
  {
    id: 'equipment',
    title: 'Оборудование',
    component: pageComponents.EquipmentPage
  },
  {
    id: 'desing',
    title: 'Проектирование',
    component: pageComponents.DesignPage
  },
  {
    id: 'accreditations',
    title: 'Аккредитации',
    component: pageComponents.AccreditationsPage
  },
  {
    id: 'news',
    title: 'Новости',
    component: pageComponents.NewsPage
  },
  {
    id: 'contacts',
    title: 'Контакты',
    component: pageComponents.ContactsPage
  }
]

const contactFormModalVisible = ref(false)
provide('contactFormModalVisible', contactFormModalVisible)
</script>

<template>
  <div class="landing_layout-header-wrap">
    <header class="landing_layout-header f ai-c jc-sb">
      <img width="164" :src="CorneliusLogo" alt="Logo" />

      <PagesNavbar :pages="pages" />
    </header>
  </div>

  <PageList :pages="pages" />

  <Teleport to="body">
    <Transition name="landing_layout-modal-anim">
      <div
        v-if="contactFormModalVisible"
        @click="contactFormModalVisible = false"
        class="landing_layout-modal landing_layout-modal-contact_form f ai-c jc-c"
      >
        <div @click.stop class="p-3 bg-default">
          <ContactForm />
        </div>
      </div>
    </Transition>
  </Teleport>
</template>

<style lang="scss" scoped>
.landing_layout {
  &-header {
    grid-column-start: 2;
    grid-column-end: 3;
    &-wrap {
      position: fixed;
      z-index: 100;
      left: 0;
      right: 0;
      display: grid;
      grid-template-columns: var(--page-px) 1fr var(--page-px);
      padding: 16px 0;
      background-color: var(--n-default);
      // background-color: rgba(255, 255, 255, 0.5);
    }
  }
  &-modal {
    position: fixed;
    z-index: 200;
    left: 0;
    right: 0;
    bottom: 0;
    top: 0;
    background-color: rgba(0, 0, 0, 0.5);
    &-anim {
      &-enter-active,
      &-leave-active {
        transition: opacity 0.5s ease;
      }

      &-enter-from,
      &-leave-to {
        opacity: 0;
      }
    }
    > div {
      width: 600px;
    }
  }
}
</style>

<style lang="scss">
.landing_layout {
  &-modal {
    .contact_form {
      button {
        width: auto !important;
      }
    }
  }
}
</style>
