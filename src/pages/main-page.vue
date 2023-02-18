<script lang="ts" setup>
import NCarousel from '@/components/carousel/n-carousel.vue';
import Slide1Img from '@/assets/images/slide-1.png';
import Slide2Img from '@/assets/images/slide-2.png';
import Slide3Img from '@/assets/images/slide-3.png';

const slides: { image: string; title: string; description: string }[] = [
  {
    image: Slide1Img,
    title: 'Человек',
    description: 'Мечтает, желает, материализует...',
  },
  {
    image: Slide2Img,
    title: 'Технологии',
    description:
      'Успех Корнелиус является результатом его технологических инноваций и опыта, накопленного на протяжении своей более чем 47-летней истории.',
  },
  {
    image: Slide3Img,
    title: 'Энергия и природа',
    description:
      'Корнелиус уделяет особое внимание аспектам экологии, в особенности энергосбережению и бережному отношению к окружающей среде',
  },
];
</script>

<template>
  <NCarousel class="main_slider" is-loop>
    <div
      class="main_slider-banner f jc-c"
      v-for="slide in slides"
      :key="slide.title"
    >
      <div class="container info-block p-5 f c-default">
        <div class="info-wrap">
          <div class="info f fd-col rg-3">
            <h1>{{ slide.title }}</h1>
            <p class="fw-medium">{{ slide.description }}</p>
          </div>
        </div>
      </div>
      <img :src="slide.image" alt="Slide" />
    </div>

    <template #back>
      <button>назад</button>
    </template>
    <template #next>
      <button>вперед</button>
    </template>
  </NCarousel>
</template>

<style lang="scss" scoped>
.main_slider {
  &-banner {
    height: 664px;
    width: 100vw;
    position: relative;
    img {
      width: 100%;
      height: 100%;
      object-fit: cover;
      filter: brightness(40%);
    }
    .info-block {
      position: absolute;
      z-index: 1;
    }
    .info-wrap {
      display: flex;
      align-items: center;
      justify-content: center;
      position: relative;
      overflow: visible;
      width: 280px;
      aspect-ratio: 1;
      background-color: rgba($color: #e12021, $alpha: 0.8);
      .info {
        position: absolute;
        width: 180%;
        left: 20%;
        p {
          margin-left: 24px;
        }
      }
    }
  }
}
</style>
