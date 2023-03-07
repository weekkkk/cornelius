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
  dateOfBirth: new Date(1997, 1, 18),
  employees: 30,
  clients: 30,
  governmentOrganizations: 160,
};

function getAge(date: Date) {
  var today = new Date();
  var birthDate = new Date(date);
  var age = today.getFullYear() - birthDate.getFullYear();
  var m = today.getMonth() - birthDate.getMonth();
  if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
    age--;
  }
  return age;
}

const age = getAge(information.dateOfBirth);

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
      <NButton :size="ESize.Large" :color="EColor.Base" square class="arrow">
        <img src="@/assets/images/icons/arrow-l.png" height="32" />
      </NButton>
    </template>
    <template #next>
      <NButton :size="ESize.Large" :color="EColor.Base" square class="arrow">
        <img src="@/assets/images/icons/arrow-r.png" height="32" />
      </NButton>
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

  <section class="info_section c-second-100 f fd-col ai-c bg-second-0 p-4 ta-c">
    <div class="container f fd-col rg-4">
      <h1>
        Корнелиус
        <span class="mark-text">
          первые
          <svg
            style="fill: var(--n-brand)"
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 500 150"
            preserveAspectRatio="none"
          >
            <path
              d="M5,125.4c30.5-3.8,137.9-7.6,177.3-7.6c117.2,0,252.2,4.7,312.7,7.6"
            ></path>
            <path
              d="M26.9,143.8c55.1-6.1,126-6.3,162.2-6.1c46.5,0.2,203.9,3.2,268.9,6.4"
            ></path>
          </svg>
        </span>
        в сфере энергосбережения
      </h1>

      <ul class="f fd-col ai-c rg-2 fs-small-p fw-medium">
        <li class="f ai-c cg-1">
          <span class="material-icons-round fs-p"> done </span>
          Основана в {{ information.dateOfBirth.getFullYear() }} году
        </li>
        <li class="f ai-c cg-1">
          <span class="material-icons-round fs-p"> done </span>
          Более 150 компаний выбрали нас
        </li>
        <li class="f ai-c cg-1">
          <span class="material-icons-round fs-p"> done </span>
          Качественная продукция от известных производителей
        </li>
      </ul>

      <ul class="info_list f fw-wrap g-3 fw-medium">
        <li class="f fd-col">
          <h1>
            {{ age }}
          </h1>
          <p class="fw-bold">{{ plural(age, declension) }} на рынке</p>
        </li>

        <li class="f fd-col">
          <h1>
            {{ information.employees }}
          </h1>
          <p class="fw-bold">сотрудников</p>
        </li>

        <li class="f fd-col">
          <h1>
            {{ information.clients }}
          </h1>
          <p class="fw-bold">постоянных клиентов</p>
        </li>

        <li class="f fd-col">
          <h1>
            {{ information.governmentOrganizations }}
          </h1>
          <p class="fw-bold">
            государственных организаций, сотрудничающих с нами
          </p>
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

  .arrow {
    --n-button-sz: 60px;
    --n-button-bg: rgba(0, 0, 0, 0.2);
    img {
      filter: invert(100%);
    }
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
  .mark-text {
    display: inline-flex;
    flex-direction: column;
    position: relative;
    svg {
      position: absolute;
      top: 0;
      width: 180px;
      left: -30px;
    }
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
