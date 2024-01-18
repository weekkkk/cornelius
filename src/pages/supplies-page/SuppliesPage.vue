<script lang="ts" setup>
import { SuppliesImage1, SuppliesImage2 } from '@/app'
import { ImageBlock, GridBlock } from '@/shared'
</script>

<template>
  <ImageBlock :src="SuppliesImage1" is-mobile-hide :l="1" :r="3" :t="5" b="end" />
  <ImageBlock
    :src="SuppliesImage2"
    is-mobile-hide
    :l="7"
    r="end"
    :t="3"
    b="end"
    :ml="1"
    :mr="5"
    :mt="4"
    :mb="8"
  />
  <GridBlock is-mobile-hide :l="3" :r="6" :t="4" b="end" :ml="2" :mr="5" :mt="4" mb="end">
    <div class="text_block">
      <p>
        ООО "Корнелиус" поставляет промышленное оборудование и материалы в сфере газификации и
        систем теплоснабжения, водоснабжения, канализации, вентиляции.
      </p>
    </div>
    <div class="f jc-fs">
      <button style="width: calc(100% / 3)">Получить предложение</button>
    </div>
  </GridBlock>
  <GridBlock
    is-mobile-hide
    class="jc-c"
    :l="2"
    :r="6"
    :t="3"
    :b="5"
    :ml="2"
    mr="end"
    :mt="3"
    :mb="4"
  >
    <h1>Поставки</h1>
  </GridBlock>

  <GridBlock is-mobile-show :l="1" r="end" :t="3" :b="8">
    <h2 class="mobile_title" style="margin-left: var(--corn-page-px)">Поставки</h2>
    <div class="text_block" style="margin-left: var(--corn-page-px)">
      <p>
        ООО "Корнелиус" поставляет промышленное оборудование и материалы в сфере газификации и
        систем теплоснабжения, водоснабжения, канализации, вентиляции.
      </p>
    </div>
    <ImageBlock
      style="margin-right: var(--corn-page-px)"
      :src="SuppliesImage1"
      :l="1"
      :r="3"
      :t="5"
      b="end"
    />

    <div class="f" style="margin: 0 var(--corn-page-px)">
      <button style="width: calc((100% / 3) * 2)">Получить предложение</button>
    </div>
  </GridBlock>
</template>
