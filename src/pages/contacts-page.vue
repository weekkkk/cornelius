<script lang="ts" setup>
import NButton from '@/components/button/n-button.vue';
import { EColor, ESize } from '@/components/enums';
import { EType } from '@/components/input/enums';
import NInput from '@/components/input/n-input.vue';
</script>

<template>
  <section class="f jc-c p-4">
    <div class="container py-4 f fd-col rg-4 pg-4">
      <h1 class="ta-c lh-no c-second-100">Контактная информация:</h1>

      <p class="c-second-75 ta-c fw-medium c-second-25">
        Наш адрес: Молдова, г.Тирасполь, ул. Карла-Либкнехта 385, каб. 201, 202,
        204
      </p>

      <iframe
        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d4589.815385174891!2d29.620437967416805!3d46.841316639079636!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40c9035ef240423b%3A0xdfb90db3821df9d5!2sSRL%20%22Cornelius%22!5e0!3m2!1sru!2sru!4v1591569728532!5m2!1sru!2sru"
        height="450"
        frameborder="0"
        style="border: 0"
        allowfullscreen
        aria-hidden="false"
        tabindex="0"
      />

      <div class="f g-4 contacts_list fw-wrap">
        <form class="f fd-col rg-3">
          <NInput placeholder="Ваше имя" :size="ESize.Large" />
          <NInput placeholder="Email" :size="ESize.Large" />
          <NInput placeholder="Контактный телефон" :size="ESize.Large" />
          <NInput
            placeholder="Сообщение"
            :size="ESize.Large"
            :type="EType.Textarea"
          />

          <NButton :color="EColor.Brand" :size="ESize.Large">
            <p class="fw-medium">ОТПРАВИТЬ</p>
          </NButton>
        </form>
        <div class="contacts f fd-col rg-4">
          <div class="f fd-col rg-2">
            <div class="f ai-c cg-2">
              <span class="material-icons-round"> mail </span>
              <h4 class="fw-regular">Email</h4>
            </div>
            <a class="fw-medium c-brand" href="mailto:corneliusgas@gmail.com">
              corneliusgas@gmail.com
            </a>
          </div>

          <div class="f fd-col rg-2">
            <div class="f ai-c cg-2">
              <span class="material-icons-round"> phone </span>
              <h4 class="fw-regular">Телефоны</h4>
            </div>

            <div class="f fd-col rg-3 c-second-75">
              <div class="f jc-sb">
                <p class="fw-bold">Центральный офис (тел/факс):</p>
                <p class="fw-medium">
                  <a class="c-brand" href="tel:+373 533 83481">
                    +373 533 83481
                  </a>
                  (9:00-17:00) <br />
                  <a class="c-brand" href="tel:+373 777 83485">
                    +373 777 83485
                  </a>
                  (9:00-17:00)
                </p>
              </div>

              <p class="fw-bold">Производственно-техническая база с. Суклея:</p>

              <div class="f jc-sb">
                <p class="fw-bold">ПТО, Маркетинг (Viber/WhatsApp):</p>
                <p class="fw-medium">
                  <a class="c-brand" href="tel:+373 777 81207">
                    +373 777 66761
                  </a>
                  (8:00-17:00) <br />
                  <a class="c-brand" href="tel:+373 795 35511">
                    +373 795 35511
                  </a>
                  (9:00-17:00)
                </p>
              </div>

              <div class="f jc-sb">
                <p class="fw-bold">Директор (Viber):</p>
                <p class="fw-medium">
                  <a class="c-brand" href="tel:+373 777 13084">
                    +373 777 13084
                  </a>
                  (8:00-17:00)
                </p>
              </div>

              <div class="f jc-sb">
                <p class="fw-bold">Проектный отдел:</p>
                <p class="fw-medium">
                  <a class="c-brand" href="tel:+373 533 53720">
                    +373 778 95589
                  </a>
                  (9:00-17:00)
                </p>
              </div>

              <div class="f jc-sb">
                <p class="fw-bold">Бухгалтерия:</p>
                <p class="fw-medium">
                  <a class="c-brand" href="tel:+373 533 53721">
                    +373 533 53721
                  </a>
                  (9:00-17:00)
                </p>
              </div>
            </div>
          </div>

          <ul class="f jc-sb fw-wrap g-3 mt-3">
            <li class="f cg-2">
              <img
                style="opacity: 0.8"
                src="@/assets/images/icons/soc1.png"
                height="42"
              />
              <div class="f fd-col rg-2">
                <h4 class="fw-regular lh-no">Telegram</h4>
                <a
                  class="c-brand fw-medium lh-no"
                  href="https://tlgg.ru/cornelius_gas"
                >
                  cornelius_gas
                </a>
              </div>
            </li>
            <li class="f cg-2">
              <img
                style="opacity: 0.8"
                src="@/assets/images/icons/soc2.png"
                height="42"
              />
              <div class="f fd-col rg-2">
                <h4 class="fw-regular lh-no">Viber</h4>
                <a
                  class="c-brand fw-medium lh-no"
                  href="viber://chat?number=%2B37377783485/"
                >
                  +373 777 83485
                </a>
              </div>
            </li>
            <li class="f cg-2">
              <img
                style="opacity: 0.8"
                src="@/assets/images/icons/soc3.png"
                height="42"
              />
              <div class="f fd-col rg-2">
                <h4 class="fw-regular lh-no">Telegram</h4>
                <a
                  class="c-brand fw-medium lh-no"
                  href="https://wa.me/37377783485"
                >
                  +373 777 83485
                </a>
              </div>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </section>
</template>

<style lang="scss" scoped>
.contacts_list {
  a:hover {
    color: var(--n-base);
  }

  form {
    flex-grow: 1;
    width: 524px;
  }

  .contacts {
    flex-grow: 1;
    width: calc(100% - 524px - 24px);
    min-width: 600px;
  }
  @media (max-width: 664px) {
    flex-direction: column;
    form {
      width: 100%;
    }
    .contacts {
      min-width: 0;
      width: 100%;
      div {
        flex-direction: column;
      }
    }
  }
}
</style>
