<script lang="ts" setup>
import { ESize, EColor } from '@/components/enums';
</script>

<template>
  <div class="brand_slider-wrap w-100">
    <NCarousel class="brand_slider" :step="3" is-loop>
      <img src="@/assets/images/brands/biasi.png" />
      <img src="@/assets/images/brands/cordivari.png" />
      <img src="@/assets/images/brands/grundfos.png" />
      <img src="@/assets/images/brands/hps.png" />
      <img src="@/assets/images/brands/itron.png" />
      <img src="@/assets/images/brands/nobel.png" />
      <img src="@/assets/images/brands/pedrollo.png" />
      <img src="@/assets/images/brands/qnergy.png" />
      <img src="@/assets/images/brands/riello.png" />
      <img src="@/assets/images/brands/viessmann.png" />
      <img src="@/assets/images/brands/WILO.png" />
      <template #back>
        <NButton :size="ESize.Large" :color="EColor.Brand" no-fill />
      </template>
      <template #next>
        <NButton :size="ESize.Large" :color="EColor.Brand" no-fill />
      </template>
    </NCarousel>
  </div>
</template>

<style lang="less" scoped></style>
