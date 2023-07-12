<script lang="ts" setup generic="T">
import { computed, onMounted } from 'vue'
import type { PageType } from '../..'
import { useRoute, useRouter } from 'vue-router'

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
</script>

<template>
  <div
    class="pages_navbar f ai-c cg-3 fw-medium ff-OS"
    :class="{ 'c-default': activePage?.id == 'main' }"
  >
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
  @media (max-width: 800px) {
    display: none;
  }
}
</style>
