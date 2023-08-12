<script lang="ts" setup>
import { SuppliesImage1, SuppliesImage2 } from '@/app'
import { ImageBlock, GridBlock } from '@/shared'
import { inject } from 'vue'

const contactFormModalVisible = inject('contactFormModalVisible')
</script>

<template>
  <ImageBlock :src="SuppliesImage1" :l="1" :r="3" :t="5" b="end" />
  <ImageBlock :src="SuppliesImage2" :l="7" r="end" :t="3" b="end" />
  <GridBlock :l="3" :r="6" :t="4" b="end">
    <div class="text_block">
      <p>
        ООО "Корнелиус" поставляет промышленное оборудование и материалы в сфере газификации и
        систем теплоснабжения, водоснабжения, канализации, вентиляции
      </p>
    </div>
    <div class="f jc-fs">
      <button style="width: calc(100% / 3)">Каталог товаров</button>
    </div>
  </GridBlock>

  <GridBlock class="jc-c" :l="2" :r="6" :t="3" :b="5">
    <h1>Поставки</h1>
  </GridBlock>
</template>
