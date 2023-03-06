<script lang="ts" setup>
import NButton from '@/components/button/n-button.vue';
import NCarousel from '@/components/carousel/n-carousel.vue';
import { EColor, ESize } from '@/components/enums';
</script>

<template>
  <section class="f jc-c p-4">
    <div class="container f fd-col rg-3 py-4">
      <h1 class="c-second-100 ta-c">Каталог оборудования</h1>
      <div class="f fd-col ta-j rg-2 c-second-25 fw-medium">
        <p>
          ООО "Корнелиус" поставляет промышленное оборудование в сфере
          газификации и систем теплоснабжения.
        </p>
        <p>
          Счётчики, электронные корректоры объёма газа, горелки, котлы, насосы
          по выгодным (лучшим) ценам с доставкой по Приднестровью, Молдове и
          Украине.
        </p>
      </div>
    </div>
  </section>

  <section class="f jc-c p-4">
    <div class="container f">
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
            <NButton :size="ESize.Large" :color="EColor.Brand" no-fill>
              &lt;
            </NButton>
          </template>
          <template #next>
            <NButton :size="ESize.Large" :color="EColor.Brand" no-fill>
              &gt;
            </NButton>
          </template>
        </NCarousel>
      </div>
    </div>
  </section>
</template>
