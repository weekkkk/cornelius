<script lang="ts" setup>
import { Accreditation_0709_19, Accreditation_0893_21, Accreditation_0687_19, License, AccreditationsImage1 } from '@/app'
import { ButtonBlock, ImageBlock, TextBlock, TitleBlock } from '@/shared'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <TitleBlock
    :x-start="5"
    x-end="end"
    :y-start="1"
    :y-end="3"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="2"
    :mobile-y-end="3"
  >
    Аккредитации
  </TitleBlock>

  <TextBlock
    style="
      --n-second-0: transparent;
      --text_block-jc: flex-start;
      --text_block-padding: 32px 0;
      --text_block-jc: flex-start;
    "
    :x-start="5"
    x-end="end"
    :y-start="3"
    :y-end="6"
    :mobile-x-start="2"
    mobile-x-end="end"
    :mobile-y-start="5"
    :mobile-y-end="6"
  >
    <div class="accreditations_page-link_list f fd-col rg-3">
      <a :href="Accreditation_0709_19" target="_blank">Аккредитация 0709-19</a>
      <a :href="Accreditation_0893_21" target="_blank">Аккредитация 0893-21</a>
      <a :href="Accreditation_0687_19" target="_blank">Аккредитация 0687-19</a>
      <a :href="Accreditation_0687_19" target="_blank">Аккредитация 0985-23</a>
      <a :href="License" target="_blank">Лицензия ООО Корнелиус</a>
    </div>
  </TextBlock>

  <ButtonBlock
    :x-start="5"
    :x-end="7"
    :y-start="5"
    :y-end="6"
    :mobile-x-start="2"
    :mobile-x-end="5"
    :mobile-y-start="6"
    :mobile-y-end="7"
    @click="contactFormModalVisible = true"
  >
    Получить предложение
  </ButtonBlock>

  <TextBlock
    :x-start="2"
    :x-end="4"
    :y-start="6"
    y-end="end"
    :mobile-x-start="2"
    :mobile-x-end="4"
    :mobile-y-start="4"
    :mobile-y-end="5"
  >
    <div class="f fd-col rg-3 c-second-75">
      <p>Основана в 1997 году</p>

      <p>Более 150 компаний выбрали нас</p>

      <p>Качественная продукция от известных производителей</p>
    </div>
  </TextBlock>

  <ImageBlock
    :x-start="8"
    x-end="end"
    :y-start="3"
    y-end="end"
    :src="AccreditationsImage1"
    :mobile-x-start="4"
    mobile-x-end="end"
    :mobile-y-start="3"
    :mobile-y-end="5"
  />
</template>

<style lang="scss" scoped>
.accreditations_page-link_list {
  > a {
    text-decoration: none;
    color: inherit;
    &:hover {
      opacity: 0.8;
    }
    &:active {
      opacity: 0.9;
    }
  }
}
</style>

<style lang="scss">
#accreditations.page_li {
  .page_li-content {
    @media (max-width: 800px) {
      grid-template-rows:
        calc(var(--page-px) + 40px) 54px 1fr fit-content(200px) fit-content(200px) fit-content(
          100px
        )
        var(--page-px);
    }
  }
}
</style>
