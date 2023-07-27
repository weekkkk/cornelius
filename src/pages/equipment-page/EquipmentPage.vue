<script lang="ts" setup>
import { EquipmentImage1, EquipmentImage2 } from '@/app'
import { TitleBlock, TextBlock, ButtonBlock, ImageBlock } from '@/shared'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <ImageBlock
    :x-start="1"
    :x-end="3"
    :y-start="4"
    y-end="end"
    :mobile-x-start="1"
    :mobile-x-end="5"
    :mobile-y-start="4"
    :mobile-y-end="5"
    :src="EquipmentImage1"
  />

  <ImageBlock :x-start="7" x-end="end" :y-start="3" y-end="end" :src="EquipmentImage2" is-tablet-hide />

  <TitleBlock
    :x-start="2"
    x-end="end"
    :y-start="1"
    :y-end="3"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="2"
    :mobile-y-end="3"
  >
  Поставки
  </TitleBlock>
  <TextBlock
    :x-start="3"
    :x-end="6"
    :y-start="3"
    :y-end="5"
    :mobile-x-start="1"
    :mobile-x-end="5"
    :mobile-y-start="3"
    :mobile-y-end="4"
  >
    <p>
      ООО "Корнелиус" поставляет промышленное оборудование и материалы в сфере газификации и систем теплоснабжения, водоснабжения, канализации, вентиляции
    </p>
    <!-- <p>
      Счётчики, электронные корректоры объёма газа, горелки, котлы, насосы по выгодным (лучшим)
      ценам с доставкой по Приднестровью, Молдове и Украине.
    </p> -->
  </TextBlock>

  <ButtonBlock
    :x-start="3"
    :x-end="5"
    :y-start="5"
    :y-end="6"
    :mobile-x-start="1"
    :mobile-x-end="4"
    :mobile-y-start="5"
    :mobile-y-end="6"
    @click="contactFormModalVisible = true"
  >
    Получить предложение
  </ButtonBlock>
</template>
