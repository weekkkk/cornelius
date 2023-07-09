<script lang="ts" setup>
import { CorneliusLogo, routerLinks } from '@/app'
</script>

<template>
  <header class="header_layout f ai-c cg-3 jc-sb">
    <img class="header_layout-logo_image" :src="CorneliusLogo" alt="CorneliusLogo" />

    <nav class="header_layout-nav f cg-3 ff-OS">
      <RouterLink
        class="header_layout-nav-link fw-medium"
        v-for="routerLink in Object.values(routerLinks)"
        :to="{ name: routerLink.name }"
      >
        {{ routerLink.title }}
      </RouterLink>
    </nav>
  </header>
  <slot />
</template>

<style lang="scss" scoped>
.header_layout {
  padding: 32px 64px;
  &-logo_image {
    width: 164px;
  }
  &-nav {
    &-link {
      text-decoration: none;
      color: var(--n-base);
      &.router-link-active {
        color: var(--n-brand);
      }
    }
  }
}
</style>
