<script lang="ts" setup></script>

<template>
  <section class="f fd-col ai-c p-4">
    <div class="container f ai-fe g-4 py-4 design_columns">
      <div class="f fd-col rg-3 w-100">
        <h1 class="c-second-100 ta-c">
          Проектирование <br />
          строительных объектов
        </h1>
        <div class="f fd-col ta-j rg-2 fw-medium c-second-25">
          <p>
            Компания <span class="c-brand"> Корнелиус</span> готова выполнить
            заказы в области архитектурно-строительного проектирования совместно
            с лучшими высококвалифицированными специалистами. Актуальность наших
            рабочих проектов основана на опыте монтажных работ в области
            газоснабжения, энергоснабжения, вентиляции и кондиционирования.
          </p>
          <p>
            Неоспоримое преимущество сотрудничества с нами заключается в том,
            что мы выполняем все работы «под ключ» и Заказчик имеет
            взаимоотношения только с одним подрядчиком.
          </p>
          <p>
            Также компания Корнелиус, заглядывая в будущее, готова предложить
            проектирование любых объектов в области газоснабжения
            <a
              class="h2globus-link"
              href="https://h2globus.com/"
              style="color: #0091f6"
            >
              ВОДОРОДНЫМ</a
            >
            топливом.
          </p>
        </div>
      </div>

      <div class="document_list f fd-col w-100 rg-2">
        <div class="bg-second-0 px-3 f ai-c cg-2">
          <span class="material-icons-round c-brand"> picture_as_pdf </span>
          <p class="fw-bold py-2 c-second-75">Разрешительные документы</p>
        </div>
        <ul class="f fd-col ai-fs fw-medium fs-small-p">
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0709-19.pdf"
            >
              Аккредитация 0709-19
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0893-21.pdf"
            >
              Аккредитация 0893-21
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0533-16.pdf"
            >
              Аккредитация 0533-16
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/accreditation-0687-19.pdf"
            >
              Аккредитация 0687-19
            </a>
          </li>
          <li class="py-2 px-3">
            <a
              class="c-base"
              target="_blank"
              href="@/assets/documents/license.pdf"
            >
              Лицензия ООО Корнелиус
            </a>
          </li>
        </ul>
      </div>
    </div>
    <div class="container f fd-col g-4 py-4">
      <h1 class="ta-c">Фото проектов</h1>

      <ul class="project_galery f fw-wrap g-3 jc-c">
        <li>
          <img src="@/assets/images/projects/1.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/2.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/3.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/4.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/5.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/6.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/7.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/8.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/9.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/10.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/11.png" />
        </li>
        <li>
          <img src="@/assets/images/projects/12.jpg" />
        </li>
        <li>
          <img src="@/assets/images/projects/13.jpg" />
        </li>
      </ul>
    </div>
  </section>
</template>

<style lang="scss" scoped>
.h2globus-link {
  &:hover {
    filter: brightness(110%);
  }
  &:active {
    filter: brightness(90%);
  }
}
ul.project_galery {
  li {
    width: calc((100% - var(--n-indent-3) * 4) / 5);
    overflow: hidden;
    aspect-ratio: 16 / 9;
    img {
      width: 100%;
      height: 100%;
      object-fit: cover;
    }
  }
}
.design_columns {
  @media (max-width: 624px) {
    flex-direction: column;
  }
  .document_list {
    flex-grow: 1;
    a:hover {
      color: var(--n-brand);
    }
  }
}
</style>
