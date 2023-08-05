<script lang="ts" setup>
import { TelegramIcon, WhatsAppIcon, ViberIcon } from '@/app'
</script>

<template>
  <div class="f g-4 jc-c social_links fw-bold c-second-100">
    <a target="_blank" class="f fd-col ai-c ta-c" href="https://t.me/37377783485">
      <img :src="TelegramIcon" width="100" />
      <!-- <p>Telegram</p> -->
   </a> 
    <a target="_blank" class="f fd-col ai-c ta-c" href="https://wa.me/37377783485">
      <img :src="WhatsAppIcon" width="100" />
      <!-- <p>WhatsApp</p> -->
   </a> 
    <a target="_blank" class="f fd-col ai-c ta-c" href="viber://chat?number=%2B37377783485">
      <img :src="ViberIcon" width="100" />
      <!-- <p>Viber</p> -->
   </a> 
  </div>
</template>

<style lang="scss" scoped>
.social_links {
  > a {
    text-decoration: none;
    color: inherit;
  }
}
</style>
