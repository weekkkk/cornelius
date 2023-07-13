<script lang="ts" setup generic="T">
import { computed, onMounted, ref } from 'vue'
import type { PageType } from '../..'
import { useRoute, useRouter } from 'vue-router'
import { BurgerIcon } from '@/app'

const props = defineProps<{
  pages: PageType<T>[]
}>()

const route = useRoute()
const router = useRouter()

const activePage = computed(() => {
  return props.pages.find((page) => `#${page.id}` == route.hash)
})

onMounted(() => {
  if (!activePage.value) {
    router.replace({ hash: '#main' })
  }
})

const mobileMenuVisible = ref(false)
</script>

<template>
  <div class="pages_navbar f ai-c cg-3 fw-medium ff-OS">
    <!-- :class="{ 'c-default': activePage?.id == 'main' }" -->
    <RouterLink
      v-for="page in pages"
      :key="page.id"
      class="pages_navbar-link"
      :class="{ 'pages_navbar-link-active': page.id == activePage?.id }"
      :to="{ hash: `#${page.id}` }"
    >
      {{ page.title }}
    </RouterLink>
  </div>
  <img
    class="pages_navbar-burger"
    @click="mobileMenuVisible = !mobileMenuVisible"
    :src="BurgerIcon"
    height="20"
  />
  <Teleport to="body">
    <Transition name="pages_navbar-mobile_menu-anim">
      <div class="pages_navbar-mobile_menu p-3 f fd-col jc-sb rg-3" v-if="mobileMenuVisible">
        <div class="f fd-col rg-3">
          <RouterLink
            v-for="page in pages"
            :key="page.id"
            class="pages_navbar-link"
            :class="{ 'pages_navbar-link-active': page.id == activePage?.id }"
            :to="{ hash: `#${page.id}` }"
            @click="mobileMenuVisible = false"
          >
            <h1>
              {{ page.title }}
            </h1>
          </RouterLink>
        </div>
        <slot />
      </div>
    </Transition>
  </Teleport>
</template>

<style lang="scss" scoped>
.pages_navbar {
  &-link {
    color: inherit;
    text-decoration: none;
    transition: 0.5s ease;
    &-active {
      color: var(--n-brand);
      cursor: default;
    }
    &:not(.pages_navbar-link-active) {
      &:hover {
        opacity: 0.8;
      }
      &:active {
        opacity: 0.9;
      }
    }
  }
  &-burger {
    display: none;
    cursor: pointer;
    transition: 0.5s ease;
    &:hover {
      filter: brightness(85%);
    }
    &:active {
      filter: brightness(95%);
    }
  }
  &-mobile_menu {
    position: fixed;
    z-index: 100;
    top: 68px;
    bottom: 0;
    left: 0;
    right: 0;
    background-color: var(--n-default);
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
  }
  @media (max-width: 800px) {
    display: none;
    &-burger {
      display: inline-flex;
    }
  }
}
</style>
