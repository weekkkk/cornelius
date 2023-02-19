<script lang="ts" setup>
import NButton from '@/components/button/n-button.vue';
import { EColor, ESize } from '@/components/enums';
import router from '@/router';
import { CONTACTS } from '@/router/modules/names';
</script>

<template>
  <section class="px-4 bg-second-50 h-100 f fd-col ai-c jc-sb ai-c">
    <div class="container mt-4 py-4 ta-c f fd-col rg-5">
      <h1>Страница заказа</h1>

      <p class="fs-small-p">
        Мы предлагаем оптимизировать общение с нами размещением подробного
        заказа на нашем сайте.
      </p>

      <div class="f cg-5 jc-c">
        <NButton
          style="width: 200px"
          :color="EColor.Second"
          :size="ESize.Large"
          @click="router.push({ name: CONTACTS })"
        >
          ОФОРМИТЬ ЗАКАЗ
        </NButton>
        <NButton
          style="width: 200px"
          :color="EColor.Second"
          :size="ESize.Large"
          @click="router.push({ name: CONTACTS })"
        >
          ЗАДАТЬ ВОПРОС
        </NButton>
      </div>
    </div>

    <img
      src="@/assets/images/order-banner.png"
      class="mt-3 w-100"
      style="max-width: 924px"
    />
  </section>
</template>