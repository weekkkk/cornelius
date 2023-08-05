<script lang="ts" setup>
import { MainPageVideo } from '@/app'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <div class="main_page">
    <video preload="auto" no-controls autoplay loop playsinline muted>
      <source :src="MainPageVideo" type="video/mp4" />
    </video>

    <div class="main_page-content c-default">
      <div class="main_page-title-wrap">
        <div class="main_page-title f fw-wrap">
          <h1 class="c-default ff-OS">
            <pre>Человек - </pre>
          </h1>
          <h1>
            <div class="f fd-col main_page-title-part">
              <pre>Мечтает</pre>
              <pre>Желает</pre>
              <pre>Материализует</pre>
              <pre>Мечтает</pre>
            </div>
          </h1>
        </div>
      </div>

      <div class="main_page-text f fd-col rg-2">
        <h3 class="fw-medium">Эффективное энергоснабжение</h3>

        <div class="f fd-col rg-3">
          <div class="main_page-achievements f cg-4 lh-loose">
            <p>50 сотрудников</p>
            <p>45 постоянных клиентов</p>
          </div>

          <div class="f fd-col rg-2">
            <p>
              ООО «Корнелиус» – строительное предприятие с собственным проектным бюро и торговым
              отделом. Сфера нашей деятельности – энергоснабжение различных отраслей народного
              хозяйства.
            </p>
          </div>

          <div class="f jc-s">
            <button class="px-5" @click="contactFormModalVisible = true">
              Получить предложение
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<style lang="scss" scoped>
.main_page {
  display: grid;
  grid-template-columns: inherit;
  grid-template-rows: var(--page-px) fit-content(100px) fit-content(400px) var(--page-px);
  position: relative;
  grid-column-start: 1;
  grid-column-end: end;
  grid-row-start: 1;
  grid-row-end: end;
  video {
    object-fit: cover;
    width: 100%;
    height: 120%;
    grid-column-start: 1;
    grid-column-end: end;
    grid-row-start: 1;
    grid-row-end: end;
  }
  &-content {
    display: grid;
    grid-template-columns: inherit;
    grid-template-rows: inherit;
    position: absolute;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;
    background-color: rgba(0, 0, 0, 0.5);
    @media (max-width: 800px) {
      grid-template-rows: 16px 1fr fit-content(200px) fit-content(600px) 16px;
    }
  }
  @keyframes slide {
    0% {
      transform: translateY(0%);
    }
    50% {
      transform: translateY(calc((-100% / 4) * 1));
    }
    100% {
      transform: translateY(calc((-100% / 4) * 2));
    }
    // 100% {
    //   transform: translateY(calc((-100% / 4) * 3));
    // }
  }
  &-title {
    &-part {
      animation: slide 4s forwards;
      animation-delay: 1s;
    }
    &-wrap {
      display: flex;
      align-items: flex-end;
      overflow: hidden;
      grid-column-start: 2;
      grid-column-end: end;
      grid-row-start: 2;
      grid-row-end: 5;
      pre {
        font-family: inherit;
        font-size: inherit;
      }
      @media (max-width: 800px) {
        flex-direction: column;
        --n-fs-h1: 3rem;
        justify-content: flex-end;
        grid-row-start: 2;
        grid-row-end: 4;
        align-items: flex-start;
      }
      h1 {
        height: calc(var(--n-fs-h1) * 1.5);
        overflow: hidden;
        &:last-child {
          @media (max-width: 800px) {
            --n-fs-h1: 2.5rem;
          }
        }
      }
    }
  }
  &-text {
    grid-column-start: 2;
    grid-column-end: 5;
    grid-row-start: 5;
    grid-row-end: end;

    @media (max-width: 800px) {
      --n-fs-p: 14px;
      grid-row-start: 4;
      grid-row-end: 5;
    }
  }
  &-achievements {
    p {
      border-bottom: 1px solid var(--n-default);
      white-space: nowrap;
    }
    @media (max-width: 800px) {
      flex-wrap: wrap;
      row-gap: 8px;
    }
  }
}
</style>

<style lang="scss">
.page_li {
  .main_page-title {
    transition: 1s ease;
  }
  .main_page-text {
    overflow: hidden;
    > * {
      transition: 1s ease;
    }
  }
}
.page_li:not(.page_li-active) {
  .main_page-title {
    transform: translateX(-100%);
    &-part {
      animation: none;
    }
  }
  .main_page-text {
    overflow: hidden;
    > * {
      transform: translateX(-100%);
    }
  }
}
</style>
