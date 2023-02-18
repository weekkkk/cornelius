<script lang="ts" setup>
import NCarousel from '@/components/carousel/n-carousel.vue';
import NButton from '@/components/button/n-button.vue';
import { ESize, EColor } from '@/components/enums';

import Slide1Img from '@/assets/images/slide-1.png';
import Slide2Img from '@/assets/images/slide-2.png';
import Slide3Img from '@/assets/images/slide-3.png';

/**
 * * Слайды карусели
 */
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

/**
 * * Информация
 */
const information = {
  yearOfBirth: 1997,
  employees: 30,
  clients: 30,
  governmentOrganizations: 160,
};

const age = new Date().getFullYear() - information.yearOfBirth;

function plural(number: number, titles: string[]) {
  const cases = [2, 0, 1, 1, 1, 2];
  return titles[
    number % 100 > 4 && number % 100 < 20
      ? 2
      : cases[number % 10 < 5 ? number % 10 : 5]
  ];
}
var declension = ['год', 'года', 'лет'];
</script>

<template>
  <NCarousel class="main_slider" is-loop>
    <div
      class="main_slider-banner f ai-c jc-c"
      v-for="slide in slides"
      :key="slide.title"
    >
      <div class="container info-block f c-default">
        <div class="info-wrap">
          <div class="info p-3 f fd-col rg-3">
            <h1>{{ slide.title }}</h1>
            <p>{{ slide.description }}</p>
          </div>
        </div>
      </div>
      <img :src="slide.image" alt="Slide" />
    </div>

    <template #back>
      <NButton :size="ESize.Large" :color="EColor.Base" />
    </template>
    <template #next>
      <NButton :size="ESize.Large" :color="EColor.Base" />
    </template>
  </NCarousel>

  <section class="f jc-c p-4">
    <div class="container f">
      <p class="w-100 ta-j">
        ООО «Корнелиус» – торгово-промышленное предприятие с собственным
        проектным бюро. Сфера нашей деятельности – энергоснабжение различных
        отраслей народного хозяйства. Понимая всю важность и актуальность
        перехода человечества на возобновляемые виды энергии, с момента создания
        мы разрабатываем идеи по внедрению этих видов энергии в современную
        жизнедеятельность человека.
      </p>
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
            <NButton :size="ESize.Large" :color="EColor.Brand" no-fill />
          </template>
          <template #next>
            <NButton :size="ESize.Large" :color="EColor.Brand" no-fill />
          </template>
        </NCarousel>
      </div>
    </div>
  </section>

  <section class="info_section f fd-col ai-c bg-second-0 p-4 ta-c">
    <div class="container f fd-col rg-4">
      <h1>Корнелиус <u>первые</u> в сфере энергосбережения</h1>

      <ul class="f fd-col rg-2 fs-small-p fw-medium">
        <li>Основана в {{ information.yearOfBirth }} году</li>
        <li>Более 150 компаний выбрали нас</li>
        <li>Качественная продукция от известных производителей</li>
      </ul>

      <ul class="info_list f fw-wrap g-3 fw-medium">
        <li class="f fd-col">
          <h1>
            {{ age }}
          </h1>
          <p>{{ plural(age, declension) }} на рынке</p>
        </li>

        <li class="f fd-col">
          <h1>
            {{ information.employees }}
          </h1>
          <p>сотрудников</p>
        </li>

        <li class="f fd-col">
          <h1>
            {{ information.clients }}
          </h1>
          <p>постоянных клиентов</p>
        </li>

        <li class="f fd-col">
          <h1>
            {{ information.governmentOrganizations }}
          </h1>
          <p>государственных организаций, сотрудничающих с нами</p>
        </li>
      </ul>
    </div>

    <video autoplay muted playsinline loop poster="/">
      <source src="@/assets/videos/banner.mp4" type="video/mp4" />
    </video>
  </section>
</template>

<style lang="scss" scoped>
.main_slider {
  &-banner {
    height: 464px;
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
      width: 100%;
      z-index: 1;
      padding: 48px 72px;
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
    }
  }
}
.brand_slider {
  --n-carousel-cg: 16px;
  --n-carousel-action-tx: calc(100% + 8px);

  img {
    width: 98px;
  }

  &-wrap {
    padding: 0 var(--n-ctrl-large-sz);
  }
}

.info_section {
  position: relative;
  overflow: hidden;
  video {
    position: absolute;
    object-fit: cover;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    filter: brightness(140%) blur(2px);
  }
  .container {
    z-index: 1;
    .info_list {
      li {
        flex-grow: 1;
        width: calc((100% - 16px * 3) / 4);
        min-width: 264px;
        h1 {
          font-size: 80px;
          line-height: 1;
        }
      }
    }
  }
}
</style>
