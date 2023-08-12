<script lang="ts" setup>
import { DesignImage1 } from '@/app'
import { ImageBlock, GridBlock } from '@/shared'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <ImageBlock :src="DesignImage1" :l="1" :r="5" :t="5" b="end" />
  <GridBlock :l="5" :r="9" :t="4" b="end">
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
      <button style="width: calc(100% / 4)">Каталог товаров</button>
    </div>
  </GridBlock>

  <GridBlock class="jc-c" :l="4" :r="9" :t="3" :b="5">
    <h1>Проектирование</h1>
  </GridBlock>
</template>

<style lang="scss" scoped>
</style>
