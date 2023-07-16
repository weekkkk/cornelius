<script lang="ts" setup>
import { EquipmentImage1, EquipmentImage2 } from '@/app'
import { GridBlock, ImageBlock } from '@/shared'
</script>

<template>
  <ImageBlock :src="EquipmentImage1" :l="1" :r="3" :t="5" b="end" />
  <ImageBlock :src="EquipmentImage2" :l="7" r="end" :t="3" b="end" />
  <GridBlock :l="3" :r="6" :t="4" :b="9">
    <div class="text_block">
      <p>
        ООО "Корнелиус" поставляет промышленное оборудование в сфере газификации и систем
        теплоснабжения.
      </p>
      <p>
        Счётчики, электронные корректоры объёма газа, горелки, котлы, насосы по выгодным (лучшим)
        ценам с доставкой по Приднестровью, Молдове и Украине.
      </p>
    </div>
    <div>
      <button>Получить предложение</button>
    </div>
  </GridBlock>

  <GridBlock class="jc-c" :l="2" :r="6" :t="3" :b="5">
    <h1>Оборудование</h1>
  </GridBlock>
</template>

<style lang="scss" scoped></style>
