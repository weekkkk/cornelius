<script lang="ts" setup>
import {
  Accreditation_0709_19,
  Accreditation_0893_21,
  Accreditation_0687_19,
  License,
  AccreditationsImage1
} from '@/app'
import { ImageBlock, GridBlock } from '@/shared'
</script>

<template>
  <ImageBlock is-mobile-hide :src="AccreditationsImage1" :l="8" r="end" :t="4" b="end" />
  <GridBlock is-mobile-hide class="f fd-col jc-fe" :l="2" :r="4" :t="8" b="end">
    <div class="text_block-1 c-second-75">
      <p>Основана в 1997 году</p>
      <p>Более 150 компаний выбрали нас</p>
      <p>Качественная продукция от известных производителей</p>
    </div>
  </GridBlock>
  <GridBlock is-mobile-hide class="jc-c" :l="5" r="end" :t="3" :b="5">
    <h1>Аккредитации</h1>
  </GridBlock>
  <GridBlock is-mobile-hide :l="5" :r="7" :t="4" b="end">
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

  <GridBlock is-mobile-show :l="2" r="end" :t="3" :b="8">
    <h2 class="mobile_title">Аккредитации</h2>
    <div class="f ai-fs jc-fe">
      <div class="text_block-1 c-second-75" style="flex-grow: 1">
        <p class="fs-caption">Основана в 1997 году</p>
        <p class="fs-caption">Более 150 компаний выбрали нас</p>
        <p class="fs-caption">Качественная продукция от известных производителей</p>
      </div>
      <ImageBlock
        aspect-ratio="9 / 16"
        style="width: calc(var(--corn-page-px) + (100% - var(--corn-page-px)) / 3); flex-shrink: 0"
        :src="AccreditationsImage1"
        :l="1"
        :r="3"
        :t="5"
        b="end"
      />
    </div>
    <div
      class="accreditations_page-link_list fs-h4 fw-medium"
      style="margin-right: var(--corn-page-px)"
    >
      <a :href="Accreditation_0709_19" target="_blank">Аккредитация 0709-19</a>
      <a :href="Accreditation_0893_21" target="_blank">Аккредитация 0893-21</a>
      <a :href="Accreditation_0687_19" target="_blank">Аккредитация 0687-19</a>
      <a :href="License" target="_blank">Лицензия ООО Корнелиус</a>
    </div>
    <div class="f jc-fe" style="margin-right: var(--corn-page-px);">
      <button style="width: calc((100% / 3) * 2)">
        Получить предложение
      </button>
    </div>
  </GridBlock>
</template>

<style lang="scss" scoped>
.accreditations_page {
  &-link_list {
    display: flex;
    flex-direction: column;
    row-gap: 0.44444444rem;
    padding: 2.77777778rem 0;

    a {
      text-decoration: none;
      color: inherit;
      font-family: inherit;
    }
  }
}
</style>
