<script lang="ts" setup>
import {
  Accreditation_0709_19,
  Accreditation_0893_21,
  Accreditation_0687_19,
  License,
  AccreditationsImage1
} from '@/app'
import { ImageBlock, GridBlock } from '@/shared'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <ImageBlock :src="AccreditationsImage1" :l="8" r="end" :t="4" b="end" />
  <GridBlock class="f fd-col jc-fe" :l="2" :r="4" :t="8" b="end">
    <div class="text_block-1 c-second-75">
      <p>Основана в 1997 году</p>
      <p>Более 150 компаний выбрали нас</p>
      <p>Качественная продукция от известных производителей</p>
    </div>
  </GridBlock>

  <GridBlock class="jc-c" :l="5" r="end" :t="3" :b="5">
    <h1>Аккредитации</h1>
  </GridBlock>

  <GridBlock :l="5" :r="7" :t="4" b="end">
    <div class="accreditations_page-link_list fs-h4 fw-medium">
      <a :href="Accreditation_0709_19" target="_blank">Аккредитация 0709-19</a>
      <a :href="Accreditation_0893_21" target="_blank">Аккредитация 0893-21</a>
      <a :href="Accreditation_0687_19" target="_blank">Аккредитация 0687-19</a>
      <a :href="License" target="_blank">Лицензия ООО Корнелиус</a>
    </div>
    <div class="f jc-fs">
      <button style="width: calc(100% / 2)">Получить предложение</button>
    </div>
  </GridBlock>
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
