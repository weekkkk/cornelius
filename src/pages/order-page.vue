<script lang="ts" setup>
import NButton from '@/components/button/n-button.vue';
import { EColor, ESize } from '@/components/enums';
import router from '@/router';
import { CONTACTS } from '@/router/modules/names';
</script>

<template>
  <section
    class="px-4 bg-second-50 h-100 f fd-col ai-c jc-sb ai-c"
    style="background-color: #b1bbbe"
  >
    <div class="container mt-4 py-4 ta-c f fd-col rg-5">
      <h1 class='c-brand'>Страница заказа</h1>

      <p class="fw-medium c-default">
        Мы предлагаем оптимизировать общение с нами размещением подробного
        заказа на нашем сайте.
      </p>

      <div class="f cg-5 jc-c">
        <NButton
          style="width: 200px"
          :color="EColor.Brand"
          :size="ESize.Large"
          @click="router.push({ name: CONTACTS })"
        >
          <p class="fs-small-p">ОФОРМИТЬ ЗАКАЗ</p>
        </NButton>
        <NButton
          style="width: 200px"
          :color="EColor.Default"
          :size="ESize.Large"
          @click="router.push({ name: CONTACTS })"
        >
          <p class="fs-small-p c-brand">ЗАДАТЬ ВОПРОС</p>
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
