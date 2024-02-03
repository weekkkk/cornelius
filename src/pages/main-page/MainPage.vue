<script lang="ts" setup>
import { MainPageVideo } from '@/app'
import { GridBlock } from '@/shared'
import { useRoute } from 'vue-router'
import { inject } from 'vue'

const contactFormVisible = inject('contactFormVisible')

const route = useRoute()
</script>

<template>
  <Transition
    :name="`main_page-video_fade${route.hash.slice(1).split('-').includes('main') ? '-main' : ''}`"
  >
    <div class="main_page-bg" v-if="route.hash.slice(1).split('-').includes('main')">
      <video preload="auto" no-controls autoplay loop playsinline>
        <source :src="MainPageVideo" type="video/mp4" />
      </video>
      <div class="main_page-bg-shadow" />
    </div>
  </Transition>

  <GridBlock class="main_page rg-4" is-mobile-hide :l="2" :r="9" :t="3" b="end">
    <h1 style="margin-bottom: 0">Человек - Материализует</h1>
    <h4>Эффективное энергоснабжение</h4>
    <div class="f g-5">
      <u>
        <p>50 сотрудников</p>
      </u>
      <u>
        <p>45 постоянных клиентов</p>
      </u>
    </div>
    <p style="width: 30%">
      ООО «Корнелиус» – строительное предприятие с собственным проектным бюро и торговым отделом.
      Сфера нашей деятельности – энергоснабжение различных отраслей народного хозяйства
    </p>
    <div class="f jc-fs">
      <button @click="contactFormVisible = !contactFormVisible" style="width: calc(100% / 7)">
        Получить предложение
      </button>
    </div>
  </GridBlock>

  <GridBlock class="main_page rg-3" is-mobile-show :l="2" :r="5" :t="3" :b="8">
    <h2 class="mobile_title" style="margin-bottom: 0">Человек - Материализует</h2>
    <h4>Эффективное энергоснабжение</h4>
    <div class="f g-3">
      <u>
        <p class="fs-small-p">50 сотрудников</p>
      </u>
      <u>
        <p class="fs-small-p">45 постоянных клиентов</p>
      </u>
    </div>
    <p>
      ООО «Корнелиус» – строительное предприятие с собственным проектным бюро и торговым отделом.
      Сфера нашей деятельности – энергоснабжение различных отраслей народного хозяйства
    </p>
    <div class="f">
      <button
        @click="contactFormVisible = !contactFormVisible"
        style="width: calc(((100% / 3) * 2)"
      >
        Получить предложение
      </button>
    </div>
  </GridBlock>
</template>

<style lang="scss" scoped>
.main_page {
  color: var(--n-default);

  &-bg {
    position: absolute;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;

    video {
      object-fit: cover;
      width: 100%;
      height: 120%;
    }
    &-shadow {
      position: absolute;
      left: 0;
      right: 0;
      top: 0;
      bottom: 0;
      background-color: var(--n-base);
      opacity: 0.5;
    }
  }

  &-video_fade-enter-active,
  &-video_fade-leave-active,
  &-video_fade-main-enter-active,
  &-video_fade-main-leave-active {
    transition: opacity var(--corn-ts) ease;
  }

  &-video_fade-main-enter-active,
  &-video_fade-main-leave-active {
    transition-delay: var(--corn-ts);
    @media (max-width: 1024px) {
      transition-delay: 0s;
    }
  }
  &-video_fade-enter-from,
  &-video_fade-leave-to,
  &-video_fade-main-enter-from,
  &-video_fade-main-leave-to {
    opacity: 0;
  }
}
</style>
