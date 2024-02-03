<script lang="ts" setup>
import { DesignImage1 } from '@/app'
import { ImageBlock, GridBlock } from '@/shared'
import { inject } from 'vue'

const contactFormVisible = inject('contactFormVisible')
</script>

<template>
  <ImageBlock is-mobile-hide :src="DesignImage1" :l="1" :r="5" :t="5" b="end" />
  <GridBlock is-mobile-hide :l="5" :r="9" :t="4" b="end">
    <div class="text_block">
      <p>
        Компания Корнелиус готова выполнить заказы в области архитектурно-строительного
        проектирования совместно с лучшими высококвалифицированными специалистами в области
        газоснабжения, энергоснабжения, вентиляции и кондиционирования
      </p>
      <p>Выполняем все работы «под ключ»</p>
      <p>
        Взгляд в будущее - выполняем проектирование и строительство объектов в области газоснабжения
        ВОДОРОДНЫМ топливом
      </p>
    </div>
    <div class="f jc-fe">
      <button @click="contactFormVisible = !contactFormVisible" style="width: calc(100% / 4)">Каталог товаров</button>
    </div>
  </GridBlock>
  <GridBlock is-mobile-hide class="jc-c" :l="4" :r="9" :t="3" :b="5">
    <h1>Проектирование</h1>
  </GridBlock>

  <GridBlock is-mobile-show :l="1" r="end" :t="3" :b="8">
    <h2 class="mobile_title" style="margin-left: var(--corn-page-px)">Проектирование</h2>
    <div class="text_block" style="margin-right: var(--corn-page-px)">
      <p>
        Компания Корнелиус готова выполнить заказы в области архитектурно-строительного
        проектирования совместно с лучшими высококвалифицированными специалистами в области
        газоснабжения, энергоснабжения, вентиляции и кондиционирования
      </p>
      <p>Выполняем все работы «под ключ»</p>
      <p>
        Взгляд в будущее - выполняем проектирование и строительство объектов в области газоснабжения
        ВОДОРОДНЫМ топливом
      </p>
    </div>
    <ImageBlock
      style="margin-left: var(--corn-page-px)"
      :src="DesignImage1"
      :l="1"
      :r="3"
      :t="5"
      b="end"
    />
    <div class="f" style="margin: 0 var(--corn-page-px)">
      <button @click="contactFormVisible = !contactFormVisible" style="width: calc(((100% / 3) * 2)">Каталог товаров</button>
    </div>
  </GridBlock>
</template>

<style lang="scss" scoped></style>
