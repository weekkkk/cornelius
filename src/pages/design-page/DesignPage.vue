<script lang="ts" setup>
import { DesignImage1 } from '@/app'
import { ButtonBlock, ImageBlock, TextBlock, TitleBlock } from '@/shared'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <ImageBlock
    :x-start="1"
    :x-end="5"
    :y-start="4"
    y-end="end"
    :src="DesignImage1"
    :mobile-x-start="1"
    :mobile-x-end="5"
    :mobile-y-start="4"
    :mobile-y-end="5"
  />

  <TitleBlock
    :x-start="4"
    x-end="end"
    :y-start="1"
    :y-end="3"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="2"
    :mobile-y-end="3"
  >
    Проектирование
  </TitleBlock>

  <TextBlock
    :x-start="5"
    :x-end="9"
    :y-start="3"
    :y-end="6"
    :mobile-x-start="1"
    :mobile-x-end="5"
    :mobile-y-start="3"
    :mobile-y-end="4"
  >
    <p class="fw-bold">Строительных объектов</p>
    <p class="design_page-text">
      Компания Корнелиус готова выполнить заказы в области архитектурно-строительного проектирования
      совместно с лучшими высококвалифицированными специалистами. Актуальность наших рабочих
      проектов основана на опыте монтажных работ в области газоснабжения, энергоснабжения,
      вентиляции и кондиционирования. Неоспоримое преимущество сотрудничества с нами заключается в
      том, что мы выполняем все работы «под ключ» и Заказчик имеет взаимоотношения только с одним
      подрядчиком.
    </p>

    <p class="design_page-text">
      Также компания Корнелиус, заглядывая в будущее, готова предложить проектирование любых
      объектов в области газоснабжения ВОДОРОДНЫМ топливом.
    </p>
  </TextBlock>

  <ButtonBlock
    :x-start="7"
    :x-end="9"
    :y-start="6"
    :y-end="7"
    :mobile-x-start="1"
    :mobile-x-end="4"
    :mobile-y-start="5"
    :mobile-y-end="6"
    @click="contactFormModalVisible = true"
  >
    Получить предложение
  </ButtonBlock>
</template>

<style lang="scss" scoped>
.design_page {
  &-text {
    @media (max-width: 800px) {
      font-size: 12px;
    }
  }
}
</style>
